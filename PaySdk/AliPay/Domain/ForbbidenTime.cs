using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ForbbidenTime Data Structure.
    /// </summary>
    [Serializable]
    public class ForbbidenTime : AopObject
    {
        /// <summary>
        /// 日期，格式说明：范围区间，区间之间用逗号分隔，多个区间之间用^分隔
        /// </summary>
        [XmlElement("days")]
        public string Days { get; set; }
    }
}
