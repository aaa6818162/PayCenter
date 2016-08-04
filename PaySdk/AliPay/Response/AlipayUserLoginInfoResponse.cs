using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserLoginInfoResponse.
    /// </summary>
    public class AlipayUserLoginInfoResponse : AopResponse
    {
        /// <summary>
        /// 2088102114230015
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
