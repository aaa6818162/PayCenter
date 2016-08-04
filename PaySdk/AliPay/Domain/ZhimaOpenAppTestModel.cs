using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppTestModel : AopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
