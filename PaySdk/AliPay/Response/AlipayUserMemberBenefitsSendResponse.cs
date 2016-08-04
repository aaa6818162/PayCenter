using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberBenefitsSendResponse.
    /// </summary>
    public class AlipayUserMemberBenefitsSendResponse : AopResponse
    {
        /// <summary>
        /// 权益集合
        /// </summary>
        [XmlArray("benefits")]
        [XmlArrayItem("member_benefit")]
        public List<MemberBenefit> Benefits { get; set; }

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
