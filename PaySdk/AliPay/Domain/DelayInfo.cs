using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DelayInfo : AopObject
    {
        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 分钟
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
