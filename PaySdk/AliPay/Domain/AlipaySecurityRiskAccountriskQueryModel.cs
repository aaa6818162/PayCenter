using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAccountriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskAccountriskQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
