using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetCouponTemplateCtocCreateResponse.
    /// </summary>
    public class AlipayAssetCouponTemplateCtocCreateResponse : AopResponse
    {
        /// <summary>
        /// 红包模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
