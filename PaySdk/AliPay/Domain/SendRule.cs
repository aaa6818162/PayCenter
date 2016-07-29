using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SendRule Data Structure.
    /// </summary>
    [Serializable]
    public class SendRule : AopObject
    {
        /// <summary>
        /// 满多少金额才能送券
        /// </summary>
        [XmlElement("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 发放数量
        /// </summary>
        [XmlElement("send_num")]
        public string SendNum { get; set; }
    }
}
