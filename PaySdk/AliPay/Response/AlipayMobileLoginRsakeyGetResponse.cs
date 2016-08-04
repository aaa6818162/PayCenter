using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileLoginRsakeyGetResponse.
    /// </summary>
    public class AlipayMobileLoginRsakeyGetResponse : AopResponse
    {
        /// <summary>
        /// rsa公钥
        /// </summary>
        [XmlElement("rsapk")]
        public string Rsapk { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("rsats")]
        public string Rsats { get; set; }
    }
}
