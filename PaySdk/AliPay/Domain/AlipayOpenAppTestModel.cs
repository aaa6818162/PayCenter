using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t")]
        public long T { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("tet")]
        public string Tet { get; set; }
    }
}
