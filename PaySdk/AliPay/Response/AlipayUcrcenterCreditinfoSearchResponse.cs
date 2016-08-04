using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUcrcenterCreditinfoSearchResponse.
    /// </summary>
    public class AlipayUcrcenterCreditinfoSearchResponse : AopResponse
    {
        /// <summary>
        /// 信用分结果
        /// </summary>
        [XmlElement("ali_credit_score_result")]
        public AliCreditScoreResult AliCreditScoreResult { get; set; }
    }
}
