using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySiteprobeShopPublicUnbindResponse.
    /// </summary>
    public class AlipaySiteprobeShopPublicUnbindResponse : AopResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
