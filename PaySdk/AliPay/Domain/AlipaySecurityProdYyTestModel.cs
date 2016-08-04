using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdYyTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdYyTestModel : AopObject
    {
        /// <summary>
        /// df
        /// </summary>
        [XmlElement("sss_eee")]
        public string SssEee { get; set; }
    }
}
