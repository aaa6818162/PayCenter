using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvailableVoucherTimeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AvailableVoucherTimeDTO : AopObject
    {
        /// <summary>
        /// 单位.M:月,W:周
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
