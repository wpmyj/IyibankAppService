using System;
using System.Collections.Generic;
using System.Linq;

namespace IyibankAppService.Models.Models
{
    /// <summary>
    /// 商户基本信息表
    /// </summary>
    public partial class Business
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// 默认为0其他为连锁的父id
        /// </summary>
        public long Fatherid { get; set; }

        /// <summary>
        /// 商家类型1为普通商户2为代理商
        /// </summary>
        public int Merchanttype { get; set; }

        /// <summary>
        /// 商家地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 省份的id
        /// </summary>
        public int Province { get; set; }

        /// <summary>
        /// 市的id
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 区id
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Contactnumber { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// 商户密钥
        /// </summary>
        public string PartnerKey { get; set; }

        /// <summary>
        /// 商户交易总额
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 商户当前可以提现金额
        /// </summary>
        public decimal CashAmount { get; set; }

        /// <summary>
        /// 一级商家编号
        /// </summary>
        public long OneHome { get; set; }

        /// <summary>
        /// 二级商家编号
        /// </summary>
        public long TwoHome { get; set; }

        /// <summary>
        /// 三级商家编号
        /// </summary>
        public long ThreeHome { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        public string Registrationnumber { get; set; }

        /// <summary>
        /// 注册区域
        /// </summary>
        public string Registeredregion { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        public string Registeredaddress { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        public string Organizationcode { get; set; }

        /// <summary>
        /// 办公地址
        /// </summary>
        public string Officeaddress { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        public string Businessscope { get; set; }

        /// <summary>
        /// 三证合一图片地址
        /// </summary>
        public string Threeinonepic { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        public string Blicense { get; set; }

        /// <summary>
        /// 税务登记证
        /// </summary>
        public string Regcertificate { get; set; }

        /// <summary>
        /// 组织机构代码证
        /// </summary>
        public string Codecertificate { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        public string Corporatename { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        public string Identitycard { get; set; }

        /// <summary>
        /// 身份证正面
        /// </summary>
        public string Cardpositivepic { get; set; }

        /// <summary>
        /// 身份证反面
        /// </summary>
        public string Cardotherpic { get; set; }

        /// <summary>
        /// 开户名称
        /// </summary>
        public string Accountname { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        public string Bankaccount { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        public string Bankbranch { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        public string Unionnumber { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        public string Useraccount { get; set; }

        /// <summary>
        /// 银行开户许可地址
        /// </summary>
        public string Licensepic { get; set; }

        /// <summary>
        /// 其他补充资料
        /// </summary>
        public string Otherinformation { get; set; }

        /// <summary>
        /// 0待审核1审核中2正常3审核不通过4已经锁定
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 商家可操作菜单列表
        /// </summary>
        public string Menulist { get; set; }

        /// <summary>
        /// 代理商发展的商户数量
        /// </summary>
        public long Numbermerchant { get; set; }

        /// <summary>
        /// 发展的代理总的交易金额
        /// </summary>
        public long Tranamount { get; set; }

        /// <summary>
        /// 发展的代理成功叫的金额
        /// </summary>
        public long Successamount { get; set; }

        /// <summary>
        /// 销售人员编号
        /// </summary>
        public long SalesmanId { get; set; }

        /// <summary>
        /// 销售人员名字
        /// </summary>
        public string SalesmanName { get; set; }

        /// <summary>
        /// 补充资料1
        /// </summary>
        public string Extra1 { get; set; }

        /// <summary>
        /// 补充资料2
        /// </summary>
        public string Extra2 { get; set; }

        /// <summary>
        /// 补充资料3
        /// </summary>
        public string Extra3 { get; set; }

        /// <summary>
        /// 补充资料4
        /// </summary>
        public string Extra4 { get; set; }

        /// <summary>
        /// 补充资料5
        /// </summary>
        public string Extra5 { get; set; }

        /// <summary>
        /// 资料类型0为公司1为个体工商户
        /// </summary>
        public int Genre { get; set; }

        /// <summary>
        /// 是否可以自己配置参数后台
        /// </summary>
        public int Parconfig { get; set; }

        /// <summary>
        /// 是否屏蔽信用卡
        /// </summary>
        public int Credit { get; set; }

    }
}
