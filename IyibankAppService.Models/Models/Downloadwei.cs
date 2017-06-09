using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 微众对账接口通知文件
    /// </summary>
    public partial class Downloadwei
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Credential { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Addtime { get; set; }

    }
}
