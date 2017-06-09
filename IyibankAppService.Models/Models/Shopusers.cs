using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 购物用户基本信息表
    /// </summary>
    public partial class Shopusers
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public long RegTime { get; set; }

        /// <summary>
        /// 注册Ip
        /// </summary>
        public string RegIp { get; set; }

        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public long LastTime { get; set; }

        /// <summary>
        /// 最后登陆IP
        /// </summary>
        public string LastIp { get; set; }

        /// <summary>
        /// 0无效1有效2冻结
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phonenumber { get; set; }

    }
}
