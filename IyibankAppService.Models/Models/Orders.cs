using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 商品订单表
    /// </summary>
    public partial class Orders
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 订单状态 [Description("待付款")]WaitPay = 1,[Description("待发货")]WaitDelivery,[Description("待收货")]WaitReceiving,[Description("已关闭")]Close,[Description("已完成")]Finish
        /// </summary>
        public int OrderStatus { get; set; }

        /// <summary>
        /// 订单创建日期
        /// </summary>
        public long OrderDate { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        public string CloseReason { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public long ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 商家电话
        /// </summary>
        public string SellerPhone { get; set; }

        /// <summary>
        /// 商家发货地址
        /// </summary>
        public string SellerAddress { get; set; }

        /// <summary>
        /// 商家说明
        /// </summary>
        public string SellerRemark { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 会员名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 会员留言
        /// </summary>
        public string UserRemark { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string ShipTo { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        public string CellPhone { get; set; }

        /// <summary>
        /// 收货人地址省份ID
        /// </summary>
        public int TopRegionId { get; set; }

        /// <summary>
        /// 收货人区域ID
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// 全名的收货地址
        /// </summary>
        public string RegionFullName { get; set; }

        /// <summary>
        /// 收货具体街道信息
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 快递公司
        /// </summary>
        public string ExpressCompanyName { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        public decimal Freight { get; set; }

        /// <summary>
        /// 物流订单号
        /// </summary>
        public string ShipOrderNumber { get; set; }

        /// <summary>
        /// 发货日期
        /// </summary>
        public long ShippingDate { get; set; }

        /// <summary>
        /// 是否打印快递单
        /// </summary>
        public int IsPrinted { get; set; }

        /// <summary>
        /// 付款类型名称
        /// </summary>
        public string PaymentTypeName { get; set; }

        /// <summary>
        /// 付款类型使用 插件名称
        /// </summary>
        public string PaymentTypeGateway { get; set; }

        /// <summary>
        /// 付款类型编号
        /// </summary>
        public long PaymentTypeId { get; set; }

        /// <summary>
        /// 支付订单编号
        /// </summary>
        public string GatewayOrderId { get; set; }

        /// <summary>
        /// 付款注释
        /// </summary>
        public string PayRemark { get; set; }

        /// <summary>
        /// 付款日期
        /// </summary>
        public long PayDate { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        public int InvoiceType { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 完成订单日期
        /// </summary>
        public long FinishDate { get; set; }

        /// <summary>
        /// 商品总金额
        /// </summary>
        public decimal ProductTotalAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal RefundTotalAmount { get; set; }

        /// <summary>
        /// 佣金总金额
        /// </summary>
        public decimal CommisTotalAmount { get; set; }

        /// <summary>
        /// 退还佣金总金额
        /// </summary>
        public decimal RefundCommisAmount { get; set; }

        /// <summary>
        /// 来自哪个终端的订单
        /// </summary>
        public int Platform { get; set; }

        /// <summary>
        /// 针对该订单的优惠金额（用于优惠券）
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// 积分优惠金额
        /// </summary>
        public decimal IntegralDiscount { get; set; }

        /// <summary>
        /// 发票明细
        /// </summary>
        public string InvoiceContext { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public int OrderType { get; set; }

    }
}
