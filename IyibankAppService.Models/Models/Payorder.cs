using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 代付订单列表
    /// </summary>
    public partial class Payorder
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 批量付款编号
        /// </summary>
        public string Batchnumber { get; set; }

        /// <summary>
        /// 商户付款批次号
        /// </summary>
        public string out_batch_no { get; set; }

        /// <summary>
        /// 当前付款的订单数量
        /// </summary>
        public int Orderquantity { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public long PostTime { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// 付款方式名称
        /// </summary>
        public string PaymentName { get; set; }

        /// <summary>
        /// 付款方式的id
        /// </summary>
        public long Paymentid { get; set; }

        /// <summary>
        /// 系统付款编号id
        /// </summary>
        public long Paymentsystemid { get; set; }

        /// <summary>
        /// 分表条件
        /// </summary>
        public long Condition { get; set; }

        /// <summary>
        /// 订单状态0为已经提交1为成功2为已经失败
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 总付款金额
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 当前付款的总手续费
        /// </summary>
        public decimal CounterFee { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 成功付款总金额
        /// </summary>
        public decimal TrueTotalAmount { get; set; }

        /// <summary>
        /// 成功付款的手续费
        /// </summary>
        public decimal TrueCounterFee { get; set; }

    }
}
