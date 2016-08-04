using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ForbiddenVoucherTimeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ForbiddenVoucherTimeDTO : AopObject
    {
        /// <summary>
        /// 日期范围
        /// </summary>
        [XmlElement("days")]
        public string Days { get; set; }

        /// <summary>
        /// 时间段
        /// </summary>
        [XmlElement("times")]
        public string Times { get; set; }
    }
}
