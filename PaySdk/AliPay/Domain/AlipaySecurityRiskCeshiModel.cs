using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCeshiModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskCeshiModel : AopObject
    {
        /// <summary>
        /// asdfasdfsadf
        /// </summary>
        [XmlElement("asdjasd")]
        public string Asdjasd { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [XmlElement("dddd")]
        public string Dddd { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [XmlElement("sss_eee")]
        public string SssEee { get; set; }
    }
}
