using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 代理利润分析每个商家创造的每个通道总利润分析
    /// </summary>
    public partial class Agentprofitchannelall
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
        /// 最后更新数据时间
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
