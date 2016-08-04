using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppCodetestResponse.
    /// </summary>
    public class AlipayOpenAppCodetestResponse : AopResponse
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [XmlElement("paramtest")]
        public string Paramtest { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [XmlElement("paramtesttest")]
        public string Paramtesttest { get; set; }
    }
}
