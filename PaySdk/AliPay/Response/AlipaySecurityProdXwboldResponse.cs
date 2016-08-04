using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdXwboldResponse.
    /// </summary>
    public class AlipaySecurityProdXwboldResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwbout")]
        public string Xwbout { get; set; }
    }
}
