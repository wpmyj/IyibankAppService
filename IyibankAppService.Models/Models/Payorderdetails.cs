using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Payorderdetails
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 分表建
        /// </summary>
        public long Conditions { get; set; }

        /// <summary>
        /// 批量付款编号
        /// </summary>
        public string Batchnumber { get; set; }

        /// <summary>
        /// 系统订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 商户交易订单号
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 商户付款批次号
        /// </summary>
        public string out_batch_no { get; set; }

        /// <summary>
        /// 付款订单数
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
        /// 付款方式id
        /// </summary>
        public long Paymentid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Paymentsystemid { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 付款通道名称
        /// </summary>
        public string Billname { get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        public decimal CounterFee { get; set; }

        /// <summary>
        /// 异步通知地址
        /// </summary>
        public string notify_url { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// 收款人卡号
        /// </summary>
        public string Cardnumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 提交返回的订单号
        /// </summary>
        public string ThirdOrderNumber { get; set; }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        public string accbankname { get; set; }

    }
}
