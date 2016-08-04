using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAlisisAuthorityQueryResponse.
    /// </summary>
    public class AlipayDataAlisisAuthorityQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
