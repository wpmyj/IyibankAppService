using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 进件详情
    /// </summary>
    public partial class Merchant
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public long Businessid { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string merchantName { get; set; }

        /// <summary>
        /// 外商户号
        /// </summary>
        public string outMerchantId { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        public string feeType { get; set; }

        /// <summary>
        /// 商户经营类型
        /// </summary>
        public int mchDealType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 申请的支付类型
        /// </summary>
        public long chPayAuth { get; set; }

        /// <summary>
        /// 支付类型的名称
        /// </summary>
        public string chPayName { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        public string merchantShortName { get; set; }

        /// <summary>
        /// 行业类别
        /// </summary>
        public int industrId { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string tel { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 企业法人
        /// </summary>
        public string legalPerson { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string principal { get; set; }

        /// <summary>
        /// 负责人手机号
        /// </summary>
        public string principalMobile { get; set; }

        /// <summary>
        /// 负责人身份证
        /// </summary>
        public string idCode { get; set; }

        /// <summary>
        /// 身份证正面图片
        /// </summary>
        public string indentityPhoto { get; set; }

        /// <summary>
        /// 身份证背面图片
        /// </summary>
        public string indentityBlackPhoto { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        public string licensePhoto { get; set; }

        /// <summary>
        /// 商户协议照
        /// </summary>
        public string protocolPhoto { get; set; }

        /// <summary>
        /// 组织机构代码 照
        /// </summary>
        public string orgPhoto { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public string accountCode { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        public string bankId { get; set; }

        /// <summary>
        /// 开户人
        /// </summary>
        public string accountName { get; set; }

        /// <summary>
        /// 帐户类型
        /// </summary>
        public int accountType { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        public string contactLine { get; set; }

        /// <summary>
        /// 开户支行名称
        /// </summary>
        public string bankName { get; set; }

        /// <summary>
        /// 开户支行所在 省
        /// </summary>
        public string Bankprovince { get; set; }

        /// <summary>
        /// 开户支行所在 市
        /// </summary>
        public string Bankcity { get; set; }

        /// <summary>
        /// 持卡人证件类 型
        /// </summary>
        public int idCardType { get; set; }

        /// <summary>
        /// 持卡人证件号 码
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 持卡人地址
        /// </summary>
        public string Bankaddress { get; set; }

        /// <summary>
        /// 持卡人手机号码
        /// </summary>
        public string Banktel { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public string AutName { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int AuditState { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }

        /// <summary>
        /// 威富通商户号
        /// </summary>
        public string merchantId { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        public string customePhone { get; set; }

    }
}
