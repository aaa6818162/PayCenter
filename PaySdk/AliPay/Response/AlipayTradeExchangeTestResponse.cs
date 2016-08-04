using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeExchangeTestResponse.
    /// </summary>
    public class AlipayTradeExchangeTestResponse : AopResponse
    {
        /// <summary>
        /// asdfasdf
        /// </summary>
        [XmlElement("asdfasdf")]
        public string Asdfasdf { get; set; }
    }
}
