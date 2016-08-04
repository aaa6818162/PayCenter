using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdDemoTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDemoTestModel : AopObject
    {
        /// <summary>
        /// miaoshu
        /// </summary>
        [XmlArray("tel_test")]
        [XmlArrayItem("asdf")]
        public List<Asdf> TelTest { get; set; }
    }
}
