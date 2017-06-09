using System;
using System.Collections.Generic;
using System.Text;

namespace IyibankAppService.Utils.OAuth
{
    public static class JwtHelper
    {
        /// <summary>
        /// 验证jwt配置是否合法
        /// </summary>
        /// <param name="options">配置对象</param>
        public static void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));
            if (options.ValidFor <= TimeSpan.Zero)
                throw new ArgumentException("Must be a non-zero TimeSpan", nameof(JwtIssuerOptions.ValidFor));
            if (options.SigningCredentials == null)
                throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));
            if (options.JtiGenerator == null)
                throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
        }
    }
}
