using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestALIPAY Data Structure.
    /// </summary>
    [Serializable]
    public class TestALIPAY : AopObject
    {
        /// <summary>
        /// WERGWERG
        /// </summary>
        [XmlElement("sdfgsdfg")]
        public string Sdfgsdfg { get; set; }
    }
}
