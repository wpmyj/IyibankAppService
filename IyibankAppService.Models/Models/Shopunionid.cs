using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 第三方接口唯一标识记录表
    /// </summary>
    public partial class Shopunionid
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// user表的用户id
        /// </summary>
        public long UsersId { get; set; }

        /// <summary>
        /// 用户的唯一标识
        /// </summary>
        public string UnionID { get; set; }

        /// <summary>
        /// 来源用户的店铺编号
        /// </summary>
        public long ShopID { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public long ReTime { get; set; }

    }
}
