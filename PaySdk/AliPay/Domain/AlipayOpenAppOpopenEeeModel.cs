using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpopenEeeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpopenEeeModel : AopObject
    {
        /// <summary>
        /// asd
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }
    }
}
