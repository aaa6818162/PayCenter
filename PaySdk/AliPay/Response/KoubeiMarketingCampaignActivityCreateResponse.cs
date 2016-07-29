using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动子状态，如审核中
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }
    }
}
