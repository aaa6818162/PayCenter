using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayMobileStdPublicShortlinkCreateResponse : AopResponse
    {
        /// <summary>
        /// 短链接url
        /// </summary>
        [XmlElement("shortlink")]
        public string Shortlink { get; set; }
    }
}
