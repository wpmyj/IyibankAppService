using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 店铺模板主题表
    /// </summary>
    public partial class Shopstheme
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        public string ThemeName { get; set; }

        /// <summary>
        /// 主题编号
        /// </summary>
        public string ThemeCode { get; set; }

        /// <summary>
        /// 主题介绍
        /// </summary>
        public string Description { get; set; }

    }
}
