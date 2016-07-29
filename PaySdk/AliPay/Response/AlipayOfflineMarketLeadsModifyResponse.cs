using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketLeadsModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketLeadsModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 审核状态描述
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 审核中
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

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
