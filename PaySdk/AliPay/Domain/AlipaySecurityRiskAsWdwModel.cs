using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAsWdwModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskAsWdwModel : AopObject
    {
        /// <summary>
        /// sdsd
        /// </summary>
        [XmlElement("asd")]
        public string Asd { get; set; }

        /// <summary>
        /// scscs
        /// </summary>
        [XmlElement("sss")]
        public AlipayDataStructureTestTestTest Sss { get; set; }
    }
}
