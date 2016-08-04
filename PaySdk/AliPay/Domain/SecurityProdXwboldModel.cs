using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecurityProdXwboldModel Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityProdXwboldModel : AopObject
    {
        /// <summary>
        /// sdf
        /// </summary>
        [XmlElement("xwbin")]
        public string Xwbin { get; set; }
    }
}
