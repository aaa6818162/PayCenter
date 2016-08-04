using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskMobileriskQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskMobileriskQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有风险
        /// </summary>
        [XmlElement("has_risk")]
        public string HasRisk { get; set; }

        /// <summary>
        /// 返回本次模型的infocode
        /// </summary>
        [XmlElement("info_code")]
        public RiskRankInfoCode InfoCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_rank")]
        public long RiskRank { get; set; }

        /// <summary>
        /// 风险分数
        /// </summary>
        [XmlElement("risk_score")]
        public long RiskScore { get; set; }
    }
}
