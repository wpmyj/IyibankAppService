using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;
//需要导入依赖包
using System.IdentityModel.Tokens.Jwt;
using IyibankAppService.Utils.OAuth;
using IyibankAppService.Models.Models;
using IyibankAppService.Utils.Date;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IyibankAppService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class JwtController : Controller
    {
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly ILogger _logger;

        /// <summary>
        /// 构造函数, 使用依赖注入进行相关配置
        /// </summary>
        /// <param name="jwtoptions"></param>
        /// <param name="loggerFactory"></param>
        public JwtController(IOptions<JwtIssuerOptions> jwtoptions, ILoggerFactory loggerFactory)
        {
            _jwtOptions = jwtoptions.Value;
            _logger = loggerFactory.CreateLogger<JwtController>();
            JwtHelper.ThrowIfInvalidOptions(_jwtOptions);
        }

        /// <summary>
        /// 使用了.net core 的模型绑定, 直接从表单中绑定信息,应使用'xxx-form-urlendcode'类型
        /// </summary>
        /// <param name="applicationUser">登录信息</param>
        /// <returns>登录结果access_token</returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromForm] Shopusers applicationUser)
        {
            _logger.LogInformation("Get Token");
            var identity = await LoginValidate(applicationUser);
            if (identity == null)
            {
                _logger.LogInformation($"Invalid username({applicationUser}) or password({applicationUser.Password}");
                return BadRequest("Wrong Password");
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, applicationUser.UserName),
                new Claim(JwtRegisteredClaimNames.NameId,"57614409"),
                new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeHelper.ToUnixEpochDate(_jwtOptions.IssueAt).ToString(), ClaimValueTypes.Integer64),
                identity.FindFirst("LoginCharacter")
            };

            //生成 jwt 安全token, 并编码
            var jwt = new JwtSecurityToken(
                    issuer: _jwtOptions.Issuer,
                    audience: _jwtOptions.Audience,
                    claims: claims,
                    notBefore: _jwtOptions.NotBefore,
                    expires: _jwtOptions.Expiration,
                    signingCredentials: _jwtOptions.SigningCredentials
                );
            string encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            //序列化返回的对象
            var response = new
            {
                Success = "0",
                Message = "",
                Data = new
                {
                    Access_Token = encodedJwt,
                    Expires_In = (int)_jwtOptions.ValidFor.TotalSeconds
                }
            };
            return Json(response);
        }

        /// <summary>
        /// 模拟登录验证操作
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns>带有权限的对象</returns>
        /// <remarks>此方法为验证方法, 在正式项目中作为授权和配置权限使用, 注意与start up中的权限对应</remarks>
        private static Task<ClaimsIdentity> LoginValidate(Shopusers user)
        {
            //登录用户
            if (user.UserName == "yelifei" && user.Password == "123456")
            {
                return Task.FromResult(new ClaimsIdentity(new GenericIdentity(user.UserName, "Token"),
                    new[]
                    {
                        new Claim("LoginCharacter","yelifei"),
                        new  Claim("UserId","57614409")
                    }));
            }
            //访客用户 这里不同的用户可以看成不同的角色
            if (user.UserName == "guest" && user.Password == "guest")
            {
                return Task.FromResult(new ClaimsIdentity(new GenericIdentity(user.UserName, "Token"),
                    new[]
                    {
                        new Claim("LoginCharacter","I_am_guest")
                    }));
            }
            //身份证不通过
            return Task.FromResult<ClaimsIdentity>(null);
        }
    }
}