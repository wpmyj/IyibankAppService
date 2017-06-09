using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 权限组表
    /// </summary>
    public partial class Permission
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public long Businessid { get; set; }

        /// <summary>
        /// 权限组名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 权限组内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 状态0无效1有效
        /// </summary>
        public int State { get; set; }

    }
}
