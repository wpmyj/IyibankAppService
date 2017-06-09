using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 日记记录表
    /// </summary>
    public partial class Log
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商家的id
        /// </summary>
        public long Businessid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 0查询1添加2删除3更新
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 操作内容
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public long CreateDate { get; set; }

        /// <summary>
        /// 操作ip
        /// </summary>
        public string CreateIp { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
