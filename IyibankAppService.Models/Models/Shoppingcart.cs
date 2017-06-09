using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 购物车表
    /// </summary>
    public partial class Shoppingcart
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public long ShopId { get; set; }

        /// <summary>
        /// 购物标识,多人一起购物时使用
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        /// 下单人员标识
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 下单人员名字
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 购物车内容
        /// </summary>
        public string Content { get; set; }

    }
}
