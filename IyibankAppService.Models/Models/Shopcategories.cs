using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 分类表
    /// </summary>
    public partial class Shopcategories
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public long ShopId { get; set; }

        /// <summary>
        /// 上级分类ID
        /// </summary>
        public long ParentCategoryId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long DisplaySequence { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public string IsShow { get; set; }

        /// <summary>
        /// 0产品分类1桌台分类2区域分类
        /// </summary>
        public int Type { get; set; }

    }
}
