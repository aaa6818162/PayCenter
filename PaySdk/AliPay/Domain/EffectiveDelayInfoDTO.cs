using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EffectiveDelayInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EffectiveDelayInfoDTO : AopObject
    {
        /// <summary>
        /// 类型。W:按绝对值延迟,M:按天数延迟
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
