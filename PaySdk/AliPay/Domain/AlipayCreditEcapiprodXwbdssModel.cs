using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCreditEcapiprodXwbdssModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCreditEcapiprodXwbdssModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlArray("test_id")]
        [XmlArrayItem("string")]
        public List<string> TestId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ts")]
        public string Ts { get; set; }
    }
}
