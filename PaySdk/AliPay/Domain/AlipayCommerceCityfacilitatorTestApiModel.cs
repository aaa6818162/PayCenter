using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorTestApiModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorTestApiModel : AopObject
    {
        /// <summary>
        /// {"a":"b"}
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
