using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 左侧菜单系统列表
    /// </summary>
    public partial class Leftmenu
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long FatherId { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkAddress { get; set; }

        /// <summary>
        /// 0系统管理1代理商2普通商家
        /// </summary>
        public int Targ { get; set; }

        /// <summary>
        /// 0不可用1可用
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// ico图片
        /// </summary>
        public string Ioc { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public long Sort { get; set; }

    }
}
