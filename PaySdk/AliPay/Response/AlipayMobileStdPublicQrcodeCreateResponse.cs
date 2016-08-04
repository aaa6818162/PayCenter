using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayMobileStdPublicQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("code_img")]
        public string CodeImg { get; set; }

        /// <summary>
        /// 码过期时间，单位：秒
        /// </summary>
        [XmlElement("expire_second")]
        public long ExpireSecond { get; set; }
    }
}
