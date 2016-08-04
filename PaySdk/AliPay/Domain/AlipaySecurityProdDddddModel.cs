using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdDddddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDddddModel : AopObject
    {
        /// <summary>
        /// aa
        /// </summary>
        [XmlArray("aaa")]
        [XmlArrayItem("string")]
        public List<string> Aaa { get; set; }

        /// <summary>
        /// dd
        /// </summary>
        [XmlElement("aaade")]
        public AAATest Aaade { get; set; }

        /// <summary>
        /// ddde  dde  dde
        /// </summary>
        [XmlArray("ddd")]
        [XmlArrayItem("string")]
        public List<string> Ddd { get; set; }
    }
}
