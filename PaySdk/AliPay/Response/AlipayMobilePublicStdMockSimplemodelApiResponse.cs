using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicStdMockSimplemodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicStdMockSimplemodelApiResponse : AopResponse
    {
        /// <summary>
        /// 简单模型
        /// </summary>
        [XmlElement("biz_model")]
        public SimpleMockModel BizModel { get; set; }
    }
}
