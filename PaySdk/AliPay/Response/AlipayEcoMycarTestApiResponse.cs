using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarTestApiResponse.
    /// </summary>
    public class AlipayEcoMycarTestApiResponse : AopResponse
    {
        /// <summary>
        /// asd
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
