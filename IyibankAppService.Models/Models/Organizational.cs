using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 商户组织机构表
    /// </summary>
    public partial class Organizational
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public long Fatherid { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public long Businessid { get; set; }

        /// <summary>
        /// 组织机构名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 下级编号列表
        /// </summary>
        public string Subordinate { get; set; }

        /// <summary>
        /// 状态0无效1有效
        /// </summary>
        public int State { get; set; }

    }
}
