using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTesttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTesttestModel : AopObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("tesparam")]
        public string Tesparam { get; set; }
    }
}
