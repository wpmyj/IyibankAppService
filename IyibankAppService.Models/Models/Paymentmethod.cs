using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 对外支付方式列表
    /// </summary>
    public partial class Paymentmethod
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string Applyname { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public long BusinessId { get; set; }

        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string Payname { get; set; }

        /// <summary>
        /// 支付编码
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// 支付类名称
        /// </summary>
        public string Classname { get; set; }

        /// <summary>
        /// 当前商家执行费率
        /// </summary>
        public decimal Merchantrate { get; set; }

        /// <summary>
        /// 一级商家成本
        /// </summary>
        public decimal OneCountercost { get; set; }

        /// <summary>
        /// 一级商家分润比列
        /// </summary>
        public decimal OneCounterFee { get; set; }

        /// <summary>
        /// 二级级商家成本
        /// </summary>
        public decimal TwoCountercost { get; set; }

        /// <summary>
        /// 二级商家分润比例
        /// </summary>
        public decimal TwoCounterFee { get; set; }

        /// <summary>
        /// 三级商家成本
        /// </summary>
        public decimal ThreeCountercost { get; set; }

        /// <summary>
        /// 三级商家分润比例
        /// </summary>
        public decimal ThreeCounterFee { get; set; }

        /// <summary>
        /// 支付相关参数json代付为计费梯度的json
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// 分类编号,支付，代付，鉴权
        /// </summary>
        public long Categories { get; set; }

        /// <summary>
        /// 0待审核1有效2冻结3审核中4不通过
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 支付系统编号
        /// </summary>
        public long Systemid { get; set; }

        /// <summary>
        /// 0支付公司结算1手工结算
        /// </summary>
        public int Settlement { get; set; }

        /// <summary>
        /// 结算周期t1,t0,d0
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// 应用场景
        /// </summary>
        public string Scenarios { get; set; }

        /// <summary>
        /// paymentcode的编号
        /// </summary>
        public long CodeId { get; set; }

        /// <summary>
        /// 开通了支付方式的json列表micropay，h5，pay等
        /// </summary>
        public string Approach { get; set; }

        /// <summary>
        /// 0自己通道1待申请
        /// </summary>
        public int Whetherapply { get; set; }

        /// <summary>
        /// 代付的计费类型0为按照比例1为按照单数
        /// </summary>
        public int Chargetype { get; set; }

        /// <summary>
        /// t0时候的默认结算比例
        /// </summary>
        public int Settlementratio { get; set; }

        /// <summary>
        /// 权重排序
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// 自动路由的id
        /// </summary>
        public long AutoPayId { get; set; }

    }
}
