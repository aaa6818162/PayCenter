using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataStructureTestTestTest Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataStructureTestTestTest : AopObject
    {
        /// <summary>
        /// 222
        /// </summary>
        [XmlElement("acc")]
        public string Acc { get; set; }

        /// <summary>
        /// asd
        /// </summary>
        [XmlElement("testte")]
        public AccountRecord Testte { get; set; }
    }
}
