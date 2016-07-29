using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketLeadsReleaseResponse.
    /// </summary>
    public class AlipayOfflineMarketLeadsReleaseResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部流水号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// leads主键
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
