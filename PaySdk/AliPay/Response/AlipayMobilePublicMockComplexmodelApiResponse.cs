using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMockComplexmodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockComplexmodelApiResponse : AopResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// adc
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// biz_model
        /// </summary>
        [XmlElement("simple_mock_model")]
        public SimpleMockModel SimpleMockModel { get; set; }
    }
}
