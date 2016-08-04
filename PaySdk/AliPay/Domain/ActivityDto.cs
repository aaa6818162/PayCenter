using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityDto Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityDto : AopObject
    {
        /// <summary>
        /// 活动别名
        /// </summary>
        [XmlElement("activity_alias")]
        public string ActivityAlias { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("activity_desc")]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 发放时间规则
        /// </summary>
        [XmlArray("participate_count_limit")]
        [XmlArrayItem("participate_count_dto")]
        public List<ParticipateCountDto> ParticipateCountLimit { get; set; }

        /// <summary>
        /// 发放模式
        /// </summary>
        [XmlElement("send_mode")]
        public string SendMode { get; set; }

        /// <summary>
        /// 适用门店
        /// </summary>
        [XmlArray("suitable_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitableShops { get; set; }
    }
}
