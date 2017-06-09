using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 支付编码表
    /// </summary>
    public partial class Paymentcode
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 支付名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 支付编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 0无效1有效
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        public string Approach { get; set; }

        /// <summary>
        /// 支付类名称
        /// </summary>
        public string Classname { get; set; }

        /// <summary>
        /// 图片显示地址
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public long Sorting { get; set; }

        /// <summary>
        /// 结算周期t1,t0,d0
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// 应用场景
        /// </summary>
        public string Scenarios { get; set; }

        /// <summary>
        /// 系统支付的编号
        /// </summary>
        public long SystemId { get; set; }

        /// <summary>
        /// 0支付公司结算1手工结算
        /// </summary>
        public int Settlement { get; set; }

    }
}
