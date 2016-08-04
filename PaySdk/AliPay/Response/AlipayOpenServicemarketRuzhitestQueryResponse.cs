using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketRuzhitestQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketRuzhitestQueryResponse : AopResponse
    {
        /// <summary>
        /// app是否健康
        /// </summary>
        [XmlElement("health")]
        public bool Health { get; set; }
    }
}
