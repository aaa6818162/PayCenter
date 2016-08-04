using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetCouponTemplateCtocCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCouponTemplateCtocCreateModel : AopObject
    {
        /// <summary>
        /// 可选参数，pc 红包使用地址
        /// </summary>
        [XmlElement("active_url")]
        public string ActiveUrl { get; set; }

        /// <summary>
        /// 可选参数，APP红包使用地址
        /// </summary>
        [XmlElement("app_active_url")]
        public string AppActiveUrl { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 红包发放PID  模板创建后只能用该指定PID发红包
        /// </summary>
        [XmlElement("coupon_partner_id")]
        public string CouponPartnerId { get; set; }

        /// <summary>
        /// 保证金总金额（单位：元）  等于发行预算总金额
        /// </summary>
        [XmlElement("cust_guarantee_amount")]
        public string CustGuaranteeAmount { get; set; }

        /// <summary>
        /// 领用规则，后台配置，需要提前沟通
        /// </summary>
        [XmlElement("draw_rule_uuid")]
        public string DrawRuleUuid { get; set; }

        /// <summary>
        /// 资金归集账号  支付、退款时实际使用的资金流出/注入账号
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 可选参数，C2C资金归集交易号（支付宝交易号）
        /// </summary>
        [XmlElement("fund_order_no")]
        public string FundOrderNo { get; set; }

        /// <summary>
        /// 可选参数，C2C资金归集时间
        /// </summary>
        [XmlElement("fund_trans_date")]
        public string FundTransDate { get; set; }

        /// <summary>
        /// 红包使用开始时间  当gmt_cou_rel="R"时，该值为数字（单位为天）
        /// </summary>
        [XmlElement("gmt_cou_active")]
        public string GmtCouActive { get; set; }

        /// <summary>
        /// 红包使用结束时间  当gmt_cou_rel = 'R'时，该值为数字（单位为天）
        /// </summary>
        [XmlElement("gmt_cou_expired")]
        public string GmtCouExpired { get; set; }

        /// <summary>
        /// 使用结束时间类型  A = 绝对时间，R = 相对时间
        /// </summary>
        [XmlElement("gmt_cou_rel")]
        public string GmtCouRel { get; set; }

        /// <summary>
        /// 领用结束时间
        /// </summary>
        [XmlElement("gmt_draw_end")]
        public string GmtDrawEnd { get; set; }

        /// <summary>
        /// 幂等控制业务号  需要保证全局唯一，同一个out_order_no多次调用需要保证参数一致，特别是账号和金额；
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 使用规则，后台配置，需要提前沟通
        /// </summary>
        [XmlElement("pay_rule_uuid")]
        public string PayRuleUuid { get; set; }

        /// <summary>
        /// 可选参数，红包活动地址
        /// </summary>
        [XmlElement("publish_url")]
        public string PublishUrl { get; set; }

        /// <summary>
        /// 实际红包发行人的支付宝账号；  该账号不直接参与红包支付、退款的资金流出和注入
        /// </summary>
        [XmlElement("publisher_account")]
        public string PublisherAccount { get; set; }

        /// <summary>
        /// 红包模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
