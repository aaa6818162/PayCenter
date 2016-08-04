using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdRrrDddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdRrrDddModel : AopObject
    {
        /// <summary>
        /// aad
        /// </summary>
        [XmlElement("sdf")]
        public string Sdf { get; set; }
    }
}
