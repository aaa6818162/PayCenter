using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 人群组的基本信息
        /// </summary>
        [XmlElement("crowd_group_sets")]
        public string CrowdGroupSets { get; set; }

        /// <summary>
        /// 返回接记录的总条数
        /// </summary>
        [XmlElement("total_number")]
        public string TotalNumber { get; set; }
    }
}
