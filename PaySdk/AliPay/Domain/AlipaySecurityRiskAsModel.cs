using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAsModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskAsModel : AopObject
    {
        /// <summary>
        /// zxc
        /// </summary>
        [XmlElement("aaa")]
        public AAATest Aaa { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [XmlElement("cccc")]
        public AccountRecord Cccc { get; set; }
    }
}
