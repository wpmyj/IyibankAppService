using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 支付分类表
    /// </summary>
    public partial class Paymentcategories
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 支付分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 0不可用1可用
        /// </summary>
        public int State { get; set; }

    }
}
