using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCountModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdCountModel : AopObject
    {
        /// <summary>
        /// 由人群标签及标签值组成
        /// </summary>
        [XmlElement("conditions")]
        public string Conditions { get; set; }

        /// <summary>
        /// 如果conditions为空，则以人群中ID为准，否则以conditions为准
        /// </summary>
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 细分维度
        /// </summary>
        [XmlElement("dimensions")]
        public string Dimensions { get; set; }
    }
}
