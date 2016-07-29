using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConstraintInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConstraintInfo : AopObject
    {
        /// <summary>
        /// 人群规则组Id
        /// </summary>
        [XmlElement("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 消费单品的列表
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 最低消费
        /// </summary>
        [XmlElement("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 适用的门店列表
        /// </summary>
        [XmlArray("suit_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 用户享受次数
        /// </summary>
        [XmlElement("user_win_count")]
        public string UserWinCount { get; set; }

        /// <summary>
        /// 用户能够享受的频率
        /// </summary>
        [XmlElement("user_win_frequency")]
        public string UserWinFrequency { get; set; }
    }
}
