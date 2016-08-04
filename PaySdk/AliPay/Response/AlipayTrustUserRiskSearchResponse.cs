using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserRiskSearchResponse.
    /// </summary>
    public class AlipayTrustUserRiskSearchResponse : AopResponse
    {
        /// <summary>
        /// 风险名单查询结果
        /// </summary>
        [XmlElement("ali_trust_risk_user")]
        public AliTrustRiskUser AliTrustRiskUser { get; set; }
    }
}
