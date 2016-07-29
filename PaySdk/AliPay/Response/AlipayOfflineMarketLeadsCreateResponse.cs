using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketLeadsCreateResponse.
    /// </summary>
    public class AlipayOfflineMarketLeadsCreateResponse : AopResponse
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
        /// 如果新增的leads需要审核，该状态非空
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// leads创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// leads主键，无需审核的leads，直接创建。该字段非空
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 外部流水好
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
