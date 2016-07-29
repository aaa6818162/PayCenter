using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 详见人群组列表查询的人群组crowd_group_info对象
        /// </summary>
        [XmlElement("crowd_group_info")]
        public string CrowdGroupInfo { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
