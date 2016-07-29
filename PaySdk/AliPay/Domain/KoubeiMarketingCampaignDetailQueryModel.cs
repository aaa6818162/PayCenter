using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignDetailQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
