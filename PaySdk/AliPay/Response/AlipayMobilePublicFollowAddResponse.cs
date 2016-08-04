using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicFollowAddResponse.
    /// </summary>
    public class AlipayMobilePublicFollowAddResponse : AopResponse
    {
        /// <summary>
        /// 成功与否的标志
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 添加关注失败
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
