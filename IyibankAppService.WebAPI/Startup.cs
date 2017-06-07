using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using IyibankAppService.Utils.Encryption;
using System.Security.Cryptography;
using IyibankAppService.Utils.OAuth;
using Microsoft.IdentityModel.Tokens;

namespace IyibankAppService.WebAPI
{
    public class Startup
    {
        private readonly JWTTokenOptions _tokenOptions = new JWTTokenOptions();
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string keyDir = PlatformServices.Default.Application.ApplicationBasePath;
            if (RSAUtils.TryGetKeyParameters(keyDir, true, out RSAParameters keyParams) == false)
            {
                keyParams = RSAUtils.GenerateAndSaveKey(keyDir);
            }
            _tokenOptions.Key = new RsaSecurityKey(keyParams);
            _tokenOptions.Issuer = "TestIssuer"; // 签发者名称
            _tokenOptions.Credentials = new SigningCredentials(_tokenOptions.Key, SecurityAlgorithms.RsaSha256Signature);
            // 添加到 IoC 容器
            services.AddSingleton(_tokenOptions);
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
