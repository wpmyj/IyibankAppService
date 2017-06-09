using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 应用列表
    /// </summary>
    public partial class Paymentapplication
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string Companyname { get; set; }

        /// <summary>
        /// 路由名称
        /// </summary>
        public string Applyname { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 支付方式的编码
        /// </summary>
        public long PaymentId { get; set; }

        /// <summary>
        /// 0待审核1有效2冻结
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 应用密钥
        /// </summary>
        public string PartnerKey { get; set; }

        /// <summary>
        /// 费率千分之几
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// 路由数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 开始使用时间
        /// </summary>
        public long StartTime { get; set; }

        /// <summary>
        /// 结束使用时间
        /// </summary>
        public long EndTime { get; set; }

        /// <summary>
        /// 路由方式
        /// </summary>
        public int Mode { get; set; }

        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string PaymentName { get; set; }

    }
}
