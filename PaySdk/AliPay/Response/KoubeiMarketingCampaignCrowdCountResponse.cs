using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCountResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCountResponse : AopResponse
    {
        /// <summary>
        /// 各个细分维度的值
        /// </summary>
        [XmlElement("dimension_values")]
        public string DimensionValues { get; set; }

        /// <summary>
        /// 人群组的汇总统计值total是人数，sum是交易金额
        /// </summary>
        [XmlElement("summary_values")]
        public string SummaryValues { get; set; }
    }
}
