using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 对账单表
    /// </summary>
    public partial class Reconciliation
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
        /// 渠道名称
        /// </summary>
        public string Billname { get; set; }

        /// <summary>
        /// 账单日期
        /// </summary>
        public long BillDate { get; set; }

        /// <summary>
        /// 交易总额
        /// </summary>
        public decimal Totaltransaction { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        public decimal SettlementAmount { get; set; }

        /// <summary>
        /// 账单生成日期
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 账单下载地址
        /// </summary>
        public string Billingaddress { get; set; }

    }
}
