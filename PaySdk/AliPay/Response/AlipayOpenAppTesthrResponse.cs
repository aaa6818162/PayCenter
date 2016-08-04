using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTesthrResponse.
    /// </summary>
    public class AlipayOpenAppTesthrResponse : AopResponse
    {
        /// <summary>
        /// a
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
