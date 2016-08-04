using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTestOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportTestOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 出参示例
        /// </summary>
        [XmlElement("outparams")]
        public string Outparams { get; set; }
    }
}
