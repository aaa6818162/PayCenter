using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsuranceAccountInsureResponse.
    /// </summary>
    public class AlipayInsuranceAccountInsureResponse : AopResponse
    {
        /// <summary>
        /// 用户是否已投保
        /// </summary>
        [XmlElement("insured")]
        public bool Insured { get; set; }

        /// <summary>
        /// 请求提示文本
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
