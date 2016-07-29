using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Condition Data Structure.
    /// </summary>
    [Serializable]
    public class Condition : AopObject
    {
        /// <summary>
        /// 字段名称.name:活动名称 startTime:开始时间，endTime:结束时间，status：活动状态。
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [XmlElement("field_value")]
        public string FieldValue { get; set; }

        /// <summary>
        /// 操作符,EQUAL:等于,IN:范围。目前支持field_name=status.operator=IN.多个状态以"|"分隔
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
