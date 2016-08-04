using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoMock Data Structure.
    /// </summary>
    [Serializable]
    public class EcoMock : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("eco_name")]
        public string EcoName { get; set; }
    }
}
