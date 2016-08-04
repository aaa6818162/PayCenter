using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberBenefitsVerifyResponse.
    /// </summary>
    public class AlipayUserMemberBenefitsVerifyResponse : AopResponse
    {
        /// <summary>
        /// 权益信息
        /// </summary>
        [XmlElement("benefit")]
        public MemberBenefit Benefit { get; set; }

        /// <summary>
        /// 处理结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 处理结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
