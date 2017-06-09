using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 销售人员按照每天的统计流水
    /// </summary>
    public partial class Salestoday
    {
        /// <summary>
        /// 销售人员编号
        /// </summary>
        public long SalesmanId { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public long Timehours { get; set; }

        /// <summary>
        /// 订单总数
        /// </summary>
        public long Totalnumber { get; set; }

        /// <summary>
        /// 成功订单数
        /// </summary>
        public long Successnumber { get; set; }

        /// <summary>
        /// 交易总额
        /// </summary>
        public long TotalProfit { get; set; }

        /// <summary>
        /// 成功订单总额
        /// </summary>
        public long SuccessProfit { get; set; }

    }
}
