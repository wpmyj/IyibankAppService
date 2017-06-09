using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 用户基本信息表
    /// </summary>
    public partial class Customer
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商家编号
        /// </summary>
        public long Businessid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Truename { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string Jobnumber { get; set; }

        /// <summary>
        /// 手势密码
        /// </summary>
        public string Gesturepassword { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public long Regtime { get; set; }

        /// <summary>
        /// 注册ip
        /// </summary>
        public string Regip { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public long Logintime { get; set; }

        /// <summary>
        /// 最后登陆ip
        /// </summary>
        public string Loginip { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 商家组织机构编号
        /// </summary>
        public long Groupingid { get; set; }

        /// <summary>
        /// 商家权限组编号
        /// </summary>
        public long Permissionid { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobilenumber { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// 是否有收款权限
        /// </summary>
        public int IsPay { get; set; }

        /// <summary>
        /// 是否有排队权限
        /// </summary>
        public int IsLineup { get; set; }

        /// <summary>
        /// 是否有购物权限
        /// </summary>
        public int IsShop { get; set; }

    }
}
