using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticateResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticateResponse : AopResponse
    {
        /// <summary>
        /// 核验结果;  IV0010:核验服务不可用;  IV0011:核验通过;  IV0012:核验不通过
        /// </summary>
        [XmlElement("verification_results")]
        public string VerificationResults { get; set; }
    }
}
