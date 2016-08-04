using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserStatusGetResponse.
    /// </summary>
    public class AlipayTrustUserStatusGetResponse : AopResponse
    {
        /// <summary>
        /// 短信授权时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 短信授权过期失效时间
        /// </summary>
        [XmlElement("over_time")]
        public string OverTime { get; set; }

        /// <summary>
        /// 短信授权发起时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 1：暂未发起授权；2：已发起授权，但暂未授权；3：授权已到期失效；4：已授权，且有效；5：授权码已失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
