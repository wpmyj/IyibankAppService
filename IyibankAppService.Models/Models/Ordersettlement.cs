using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 订单结算明细
    /// </summary>
    public partial class Ordersettlement
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public long Businessid { get; set; }

        /// <summary>
        /// 日期时间戳
        /// </summary>
        public long Condition { get; set; }

        /// <summary>
        /// 今日结算的总金额
        /// </summary>
        public decimal Totalamount { get; set; }

        /// <summary>
        /// 当前日期的押金
        /// </summary>
        public decimal Deposit { get; set; }

        /// <summary>
        /// 支付方式的id
        /// </summary>
        public long Paymentid { get; set; }

        /// <summary>
        /// 支付系统的id
        /// </summary>
        public long Paymentsystemid { get; set; }

        /// <summary>
        /// 支付名称
        /// </summary>
        public string PaymentName { get; set; }

    }
}
