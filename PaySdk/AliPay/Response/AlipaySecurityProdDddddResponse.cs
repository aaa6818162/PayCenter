using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdDddddResponse.
    /// </summary>
    public class AlipaySecurityProdDddddResponse : AopResponse
    {
        /// <summary>
        /// dd
        /// </summary>
        [XmlElement("acd")]
        public AliTrustCert Acd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("adddd")]
        public Aaa Adddd { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("aeecc")]
        public AlipayDataItemVoucherTemplete Aeecc { get; set; }
    }
}
