using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserRiskidentifyNontokenGetResponse.
    /// </summary>
    public class AlipayTrustUserRiskidentifyNontokenGetResponse : AopResponse
    {
        /// <summary>
        /// 风险识别结果
        /// </summary>
        [XmlElement("ali_trust_risk_identify")]
        public AliTrustRiskIdentify AliTrustRiskIdentify { get; set; }
    }
}
