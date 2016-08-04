using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBizprodTestResponse.
    /// </summary>
    public class AlipayBizprodTestResponse : AopResponse
    {
        /// <summary>
        /// ok
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
