using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UseTime Data Structure.
    /// </summary>
    [Serializable]
    public class UseTime : AopObject
    {
        /// <summary>
        /// 可用时间的维度
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 可用时间的时分秒时间段
        /// </summary>
        [XmlElement("times")]
        public string Times { get; set; }

        /// <summary>
        /// 维度所对应的值
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
