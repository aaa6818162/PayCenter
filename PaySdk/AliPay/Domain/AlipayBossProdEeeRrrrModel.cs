using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdEeeRrrrModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdEeeRrrrModel : AopObject
    {
        /// <summary>
        /// aaaa
        /// </summary>
        [XmlElement("aaaa")]
        public string Aaaa { get; set; }
    }
}
