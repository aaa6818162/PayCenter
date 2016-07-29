using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampBaseDto Data Structure.
    /// </summary>
    [Serializable]
    public class CampBaseDto : AopObject
    {
        /// <summary>
        /// 活动审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 招商状态
        /// </summary>
        [XmlElement("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态,CREATED:草稿，ENABLED：生效，DISABLED：无效，STARTED：启动，CLOSED：停止，FINISHED：完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 活动类型.DIRECT_SEND:直发奖,CONSUME_SEND:消费送
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
