using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Shop
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 店铺等级
        /// </summary>
        public long GradeId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺LOGO路径
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 预留子域名，未使用
        /// </summary>
        public string SubDomains { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// 是否开启了位置导航
        /// </summary>
        public string IsMap { get; set; }

        /// <summary>
        /// 是否开启在线预订
        /// </summary>
        public string IsReservation { get; set; }

        /// <summary>
        /// 店铺状态
        /// </summary>
        public int ShopStatus { get; set; }

        /// <summary>
        /// 审核拒绝原因
        /// </summary>
        public string RefuseReason { get; set; }

        /// <summary>
        /// 店铺创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 店铺过期日期
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司省市区
        /// </summary>
        public int CompanyRegionId { get; set; }

        /// <summary>
        /// 公司地址
        /// </summary>
        public string CompanyAddress { get; set; }

        /// <summary>
        /// 公司电话
        /// </summary>
        public string CompanyPhone { get; set; }

        /// <summary>
        /// 公司员工数量
        /// </summary>
        public int CompanyEmployeeCount { get; set; }

        /// <summary>
        /// 公司经营范围
        /// </summary>
        public decimal CompanyRegisteredCapital { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactsName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactsPhone { get; set; }

        /// <summary>
        /// 联系Email
        /// </summary>
        public string ContactsEmail { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        public string BusinessLicenceNumber { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        public string BusinessLicenceNumberPhoto { get; set; }

        /// <summary>
        /// 营业执照所在地
        /// </summary>
        public int BusinessLicenceRegionId { get; set; }

        /// <summary>
        /// 营业执照有效期开始
        /// </summary>
        public DateTime BusinessLicenceStart { get; set; }

        /// <summary>
        /// 营业执照有效期
        /// </summary>
        public DateTime BusinessLicenceEnd { get; set; }

        /// <summary>
        /// 法定经营范围
        /// </summary>
        public string BusinessSphere { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 组织机构执照
        /// </summary>
        public string OrganizationCodePhoto { get; set; }

        /// <summary>
        /// 一般纳税人证明
        /// </summary>
        public string GeneralTaxpayerPhot { get; set; }

        /// <summary>
        /// 银行开户名
        /// </summary>
        public string BankAccountName { get; set; }

        /// <summary>
        /// 公司银行账号
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// 开户银行支行名称
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 支行联行号
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 开户银行所在地
        /// </summary>
        public int BankRegionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BankPhoto { get; set; }

        /// <summary>
        /// 税务登记证
        /// </summary>
        public string TaxRegistrationCertificate { get; set; }

        /// <summary>
        /// 税务登记证号
        /// </summary>
        public string TaxpayerId { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string TaxRegistrationCertificatePhoto { get; set; }

        /// <summary>
        /// 支付凭证
        /// </summary>
        public string PayPhoto { get; set; }

        /// <summary>
        /// 支付注释
        /// </summary>
        public string PayRemark { get; set; }

        /// <summary>
        /// 商家发货人名称
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// 商家发货人地址
        /// </summary>
        public string SenderAddress { get; set; }

        /// <summary>
        /// 商家发货人电话
        /// </summary>
        public string SenderPhone { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        public decimal Freight { get; set; }

        /// <summary>
        /// 多少钱开始免运费
        /// </summary>
        public decimal FreeFreight { get; set; }

        /// <summary>
        /// 注册步骤
        /// </summary>
        public int Stage { get; set; }

        /// <summary>
        /// 商家发货人省市区
        /// </summary>
        public int SenderRegionId { get; set; }

        /// <summary>
        /// 营业执照证书
        /// </summary>
        public string BusinessLicenseCert { get; set; }

        /// <summary>
        /// 商品证书
        /// </summary>
        public string ProductCert { get; set; }

        /// <summary>
        /// 其他证书
        /// </summary>
        public string OtherCert { get; set; }

        /// <summary>
        /// 法人代表
        /// </summary>
        public string legalPerson { get; set; }

        /// <summary>
        /// 公司成立日期
        /// </summary>
        public DateTime CompanyFoundingDate { get; set; }

    }
}
