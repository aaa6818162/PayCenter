using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicStdMockComplexmodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicStdMockComplexmodelApiResponse : AopResponse
    {
        /// <summary>
        /// biz_model
        /// </summary>
        [XmlElement("biz_model")]
        public SimpleMockModel BizModel { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// ADC
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
