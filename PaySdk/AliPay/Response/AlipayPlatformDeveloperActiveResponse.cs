using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPlatformDeveloperActiveResponse.
    /// </summary>
    public class AlipayPlatformDeveloperActiveResponse : AopResponse
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 操作成功
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
