using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCouponTemplateCreateResponse.
    /// </summary>
    public class AlipayCouponTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 保证金总额（注意：单位为分）
        /// </summary>
        [XmlElement("guarantee_amount")]
        public string GuaranteeAmount { get; set; }

        /// <summary>
        /// 红包模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
