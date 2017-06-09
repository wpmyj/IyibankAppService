using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 代理利润分析每个商家创造的每日利润分析
    /// </summary>
    public partial class Agentprofitchannelday
    {
        /// <summary>
        /// 代理商的编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 通道编号
        /// </summary>
        public long Alleyway { get; set; }

        /// <summary>
        /// 贡献利润的商家编号
        /// </summary>
        public long Indirect { get; set; }

        /// <summary>
        /// 分润日期
        /// </summary>
        public long Timehours { get; set; }

        /// <summary>
        /// 成功交易总额
        /// </summary>
        public decimal SuccessProfit { get; set; }

        /// <summary>
        /// 分润总额
        /// </summary>
        public decimal Totalprofit { get; set; }

    }
}
