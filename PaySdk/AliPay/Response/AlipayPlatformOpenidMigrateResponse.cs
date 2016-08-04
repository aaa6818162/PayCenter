using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPlatformOpenidMigrateResponse.
    /// </summary>
    public class AlipayPlatformOpenidMigrateResponse : AopResponse
    {
        /// <summary>
        /// 格式：a,b|c,d  老OpenId在前，新OpenId在后；以英文逗号,分隔；多组之间以竖线分隔
        /// </summary>
        [XmlElement("openidpairs")]
        public string Openidpairs { get; set; }
    }
}
