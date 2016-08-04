using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdResponse.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public AAATest Test { get; set; }
    }
}
