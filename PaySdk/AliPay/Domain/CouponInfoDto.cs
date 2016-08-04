using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class CouponInfoDto : AopObject
    {
        /// <summary>
        /// 活动地址
        /// </summary>
        [XmlElement("active_url")]
        public string ActiveUrl { get; set; }

        /// <summary>
        /// 红包面额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 红包NID
        /// </summary>
        [XmlElement("coupon_nid")]
        public string CouponNid { get; set; }

        /// <summary>
        /// 当前现金价值
        /// </summary>
        [XmlElement("current_amount")]
        public string CurrentAmount { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// gmtExpired
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 展期时间
        /// </summary>
        [XmlElement("gmt_extend")]
        public string GmtExtend { get; set; }

        /// <summary>
        /// 发行者名称
        /// </summary>
        [XmlElement("publisher_name")]
        public string PublisherName { get; set; }

        /// <summary>
        /// 红包当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板NID
        /// </summary>
        [XmlElement("template_nid")]
        public string TemplateNid { get; set; }

        /// <summary>
        /// 红包使用范围
        /// </summary>
        [XmlElement("use_area")]
        public string UseArea { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
