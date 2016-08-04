using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicFollowCheckResponse.
    /// </summary>
    public class AlipayMobileStdPublicFollowCheckResponse : AopResponse
    {
        /// <summary>
        /// boolean类型返回值，flase表示未关注，true表示已关注
        /// </summary>
        [XmlElement("follow")]
        public bool Follow { get; set; }
    }
}
