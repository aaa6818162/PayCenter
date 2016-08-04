using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppQueryTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppQueryTestModel : AopObject
    {
        /// <summary>
        /// key1
        /// </summary>
        [XmlElement("keyone")]
        public string Keyone { get; set; }
    }
}
