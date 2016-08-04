using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAlipaySecurityProdModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }
    }
}
