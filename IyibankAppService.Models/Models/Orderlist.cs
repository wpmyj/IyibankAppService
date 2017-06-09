using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Orderlist
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public long OrderType { get; set; }

        /// <summary>
        /// 订单类型名称
        /// </summary>
        public string OrderTypeName { get; set; }

        /// <summary>
        /// 本系统订单编号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string Out_Trade_No { get; set; }

        /// <summary>
        /// 支付系统订单号
        /// </summary>
        public string Transaction_Id { get; set; }

        /// <summary>
        /// 父订单号，退款订单类型时使用
        /// </summary>
        public string ParentOrder { get; set; }

        /// <summary>
        /// 第三方订单号
        /// </summary>
        public string ThirdOrderNumber { get; set; }

        /// <summary>
        /// 当前订单属于哪个用户的编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public long PostTime { get; set; }

        /// <summary>
        /// 订单交易成功时间
        /// </summary>
        public long TradingTime { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MerchantNumber { get; set; }

        /// <summary>
        /// 第三方商户号
        /// </summary>
        public string ThirdMerchantNumber { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMerchantNumber { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserIdentification { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string EquipmentNumber { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public long TransactionType { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        public int TradingStatus { get; set; }

        /// <summary>
        /// 付款银行
        /// </summary>
        public string PayingBank { get; set; }

        /// <summary>
        /// 货币种类
        /// </summary>
        public string CurrencyType { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal PreferentialAmount { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商户数据包
        /// </summary>
        public string ProductExpansion { get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        public decimal CounterFee { get; set; }

        /// <summary>
        /// 费率
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// 终端类型
        /// </summary>
        public string TerminalType { get; set; }

        /// <summary>
        /// 对账标识0为没有对账1为已经对账
        /// </summary>
        public int CheckMark { get; set; }

        /// <summary>
        /// 订单状态0为已经提交1为成功2为已经失败
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// 收银员
        /// </summary>
        public string Cashier { get; set; }

        /// <summary>
        /// 收银员Id
        /// </summary>
        public long CashierId { get; set; }

        /// <summary>
        /// 子商户ID
        /// </summary>
        public string SubMerchantID { get; set; }

        /// <summary>
        /// 一级商家编号
        /// </summary>
        public long OneHome { get; set; }

        /// <summary>
        /// 二级商家编号
        /// </summary>
        public long TwoHome { get; set; }

        /// <summary>
        /// 三级商家编号
        /// </summary>
        public long ThreeHome { get; set; }

        /// <summary>
        /// 一级商家的分润
        /// </summary>
        public decimal OneCounterFee { get; set; }

        /// <summary>
        /// 二级商家分润
        /// </summary>
        public decimal TwoCounterFee { get; set; }

        /// <summary>
        /// 三级商家分润
        /// </summary>
        public decimal ThreeCounterFee { get; set; }

        /// <summary>
        /// 当前请求的接口版本
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// 异步通知地址
        /// </summary>
        public string notify_url { get; set; }

        /// <summary>
        /// 同步通知地址
        /// </summary>
        public string callback_url { get; set; }

        /// <summary>
        /// 终端ip
        /// </summary>
        public string mch_create_ip { get; set; }

        /// <summary>
        /// 商家支付方式id
        /// </summary>
        public long Paymentid { get; set; }

        /// <summary>
        /// 系统支付id
        /// </summary>
        public long Paymentsystemid { get; set; }

        /// <summary>
        /// 日期，分表条件
        /// </summary>
        public long Condition { get; set; }

        /// <summary>
        /// 应用的id
        /// </summary>
        public long ApplicationId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public long FatherId { get; set; }

        /// <summary>
        /// 销售人员的编号
        /// </summary>
        public long SalesId { get; set; }

        /// <summary>
        /// 路由通道的id
        /// </summary>
        public long AppId { get; set; }

        /// <summary>
        /// 路由名称
        /// </summary>
        public string Routename { get; set; }

    }
}
