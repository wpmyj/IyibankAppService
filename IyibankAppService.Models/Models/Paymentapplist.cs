using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 应用支付方式的列表
    /// </summary>
    public partial class Paymentapplist
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 当前通道名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 支付方式的id和支付方式关联到一起
        /// </summary>
        public long PayId { get; set; }

        /// <summary>
        /// 支付的json
        /// </summary>
        public string PayJson { get; set; }

        /// <summary>
        /// 支付编码
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// 应用的id
        /// </summary>
        public long AppId { get; set; }

        /// <summary>
        /// 0按照订单金额1按照订单数
        /// </summary>
        public int Mode { get; set; }

        /// <summary>
        /// 权重值
        /// </summary>
        public int Weightvalue { get; set; }

        /// <summary>
        /// 金额或者订单数量
        /// </summary>
        public long Weight { get; set; }

        /// <summary>
        /// 支付类名称
        /// </summary>
        public string Classname { get; set; }

        /// <summary>
        /// 支付时候的类型编码
        /// </summary>
        public string Approach { get; set; }

        /// <summary>
        /// 状态1有效0无效
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public long Sorting { get; set; }

    }
}
