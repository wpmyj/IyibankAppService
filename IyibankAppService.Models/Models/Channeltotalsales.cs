using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 通道销售总额统计
    /// </summary>
    public partial class Channeltotalsales
    {
        /// <summary>
        /// 商家的编号0为系统管理的编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public long Timehours { get; set; }

        /// <summary>
        /// 总交易笔数
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
