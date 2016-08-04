using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdDdModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDdModel : AopObject
    {
        /// <summary>
        /// dd
        /// </summary>
        [XmlElement("dd")]
        public string Dd { get; set; }
    }
}
