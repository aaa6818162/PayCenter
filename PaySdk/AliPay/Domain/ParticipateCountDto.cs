using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipateCountDto Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipateCountDto : AopObject
    {
        /// <summary>
        /// 周期单位
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 周期值
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
