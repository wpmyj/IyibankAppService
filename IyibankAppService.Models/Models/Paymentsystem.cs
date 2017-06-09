using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 系统支付方式列表
    /// </summary>
    public partial class Paymentsystem
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string Payname { get; set; }

        /// <summary>
        /// 支付编码
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// 支付类名称
        /// </summary>
        public string Classname { get; set; }

        /// <summary>
        /// 当前通道成本费率
        /// </summary>
        public decimal Merchantrate { get; set; }

        /// <summary>
        /// 支付类别编码
        /// </summary>
        public long Categories { get; set; }

        /// <summary>
        /// 是否有效0无效1有效
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 0支付公司结算1手工结算
        /// </summary>
        public int Settlement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Approach { get; set; }

        /// <summary>
        /// 结算周期t1,t0,d0
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// 应用场景
        /// </summary>
        public string Scenarios { get; set; }

    }
}
