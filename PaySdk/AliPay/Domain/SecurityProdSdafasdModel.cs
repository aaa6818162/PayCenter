using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecurityProdSdafasdModel Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityProdSdafasdModel : AopObject
    {
        /// <summary>
        /// agfdfg
        /// </summary>
        [XmlElement("adsfadf")]
        public TestALIPAY Adsfadf { get; set; }
    }
}
