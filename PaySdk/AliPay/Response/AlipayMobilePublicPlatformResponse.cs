using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicPlatformResponse.
    /// </summary>
    public class AlipayMobilePublicPlatformResponse : AopResponse
    {
        /// <summary>
        /// 响应内容
        /// </summary>
        [XmlArray("res_content")]
        [XmlArrayItem("string")]
        public List<string> ResContent { get; set; }
    }
}
