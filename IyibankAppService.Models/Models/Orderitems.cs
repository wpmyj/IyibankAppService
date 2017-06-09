using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 订单详情表
    /// </summary>
    public partial class Orderitems
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public long ShopId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public long ProductId { get; set; }

        /// <summary>
        /// SKUId
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        public decimal ReturnQuantity { get; set; }

        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// 实际应付金额
        /// </summary>
        public decimal RealTotalPrice { get; set; }

        /// <summary>
        /// 退款价格
        /// </summary>
        public decimal RefundPrice { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// SKU颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// SKU尺寸
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// SKU版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string ThumbnailsUrl { get; set; }

        /// <summary>
        /// 分佣比例
        /// </summary>
        public decimal CommisRate { get; set; }

        /// <summary>
        /// 可退金额
        /// </summary>
        public decimal EnabledRefundAmount { get; set; }

        /// <summary>
        /// 是否为限时购商品
        /// </summary>
        public string IsLimitBuy { get; set; }

    }
}
