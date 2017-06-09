using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 通道每日交易流水统计表
    /// </summary>
    public partial class Channelflowstatistics
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 统计的时间天
        /// </summary>
        public long Timehours { get; set; }

        /// <summary>
        /// 总交易数据笔
        /// </summary>
        public long Totalnumber { get; set; }

        /// <summary>
        /// 成功交易数量笔
        /// </summary>
        public long Successnumber { get; set; }

        /// <summary>
        /// 总交易额
        /// </summary>
        public long TotalProfit { get; set; }

        /// <summary>
        /// 成功交易额
        /// </summary>
        public long SuccessProfit { get; set; }

        /// <summary>
        /// 通道名称
        /// </summary>
        public string Payname { get; set; }

        /// <summary>
        /// 通道id
        /// </summary>
        public long PayId { get; set; }

    }
}
