using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketLeadsClaimResponse.
    /// </summary>
    public class AlipayOfflineMarketLeadsClaimResponse : AopResponse
    {
        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// leads状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
