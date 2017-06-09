using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 按照月统计的代理商报表
    /// </summary>
    public partial class Agentprofitmonth
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 月的时间戳
        /// </summary>
        public long Timehours { get; set; }

        /// <summary>
        /// 贡献利润的商家编号
        /// </summary>
        public long Indirect { get; set; }

        /// <summary>
        /// 成功订单数
        /// </summary>
        public long Successnumber { get; set; }

        /// <summary>
        /// 成功金额数量
        /// </summary>
        public decimal SuccessProfit { get; set; }

        /// <summary>
        /// 总订单数
        /// </summary>
        public long Totalnumber { get; set; }

        /// <summary>
        /// 总金额数
        /// </summary>
        public decimal TotalProfit { get; set; }

        /// <summary>
        /// 分润金额
        /// </summary>
        public decimal Profit { get; set; }

    }
}
