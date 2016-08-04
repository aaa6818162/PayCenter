using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCdpCodetestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCdpCodetestModel : AopObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [XmlElement("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [XmlElement("testparamparam")]
        public string Testparamparam { get; set; }
    }
}
