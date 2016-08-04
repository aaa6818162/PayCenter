using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingDiscountActivityCreateResponse.
    /// </summary>
    public class AlipayOfflineMarketingDiscountActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 奖品id列表
        /// </summary>
        [XmlArray("prize_ids")]
        [XmlArrayItem("string")]
        public List<string> PrizeIds { get; set; }
    }
}
