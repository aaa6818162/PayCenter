using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTesthrModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTesthrModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("testa")]
        public string Testa { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("testb")]
        public AAATest Testb { get; set; }
    }
}
