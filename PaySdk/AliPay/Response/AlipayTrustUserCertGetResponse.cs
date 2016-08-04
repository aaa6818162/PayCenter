using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserCertGetResponse.
    /// </summary>
    public class AlipayTrustUserCertGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用认证结果
        /// </summary>
        [XmlElement("ali_trust_cert")]
        public AliTrustCert AliTrustCert { get; set; }
    }
}
