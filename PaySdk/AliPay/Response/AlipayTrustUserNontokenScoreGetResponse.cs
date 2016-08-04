using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserNontokenScoreGetResponse.
    /// </summary>
    public class AlipayTrustUserNontokenScoreGetResponse : AopResponse
    {
        /// <summary>
        /// 服务窗返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 服务窗返回码含义
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
