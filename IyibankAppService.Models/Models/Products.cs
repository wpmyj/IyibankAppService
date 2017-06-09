using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 商品表
    /// </summary>
    public partial class Products
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public long ShopId { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public long TypeId { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        public long BrandId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 广告词
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// 销售状态
        /// </summary>
        public int SaleStatus { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int AuditStatus { get; set; }

        /// <summary>
        /// 添加日期
        /// </summary>
        public long AddedDate { get; set; }

        /// <summary>
        /// 主图路径
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// 是否有SKU
        /// </summary>
        public string HasSKU { get; set; }

        /// <summary>
        /// 浏览次数
        /// </summary>
        public long VistiCounts { get; set; }

        /// <summary>
        /// 销售量
        /// </summary>
        public long SaleCounts { get; set; }

        /// <summary>
        /// 运费模板ID
        /// </summary>
        public long FreightTemplateId { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// 体积
        /// </summary>
        public decimal Volume { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public long Quantity { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        public string MeasureUnit { get; set; }

        /// <summary>
        /// 修改状态 0 正常 1己修改 2待审核 3 己修改并待审核
        /// </summary>
        public int EditStatus { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IsPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IsLineup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IsShop { get; set; }

    }
}
