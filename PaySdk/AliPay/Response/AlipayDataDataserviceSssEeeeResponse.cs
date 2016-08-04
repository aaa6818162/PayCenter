using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSssEeeeResponse.
    /// </summary>
    public class AlipayDataDataserviceSssEeeeResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("dddd")]
        public string Dddd { get; set; }
    }
}
