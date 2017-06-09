using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 每小时统计信息
    /// </summary>
    public partial class Everyhourstatistics
    {
        /// <summary>
        /// 商户编号0为系统管理
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 小时数的时间戳
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

    }
}
