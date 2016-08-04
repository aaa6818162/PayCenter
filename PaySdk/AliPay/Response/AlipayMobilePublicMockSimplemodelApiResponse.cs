using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMockSimplemodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockSimplemodelApiResponse : AopResponse
    {
        /// <summary>
        /// mock
        /// </summary>
        [XmlElement("simple_mock_model")]
        public SimpleMockModel SimpleMockModel { get; set; }
    }
}
