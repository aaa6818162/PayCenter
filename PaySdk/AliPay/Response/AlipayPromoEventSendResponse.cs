using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPromoEventSendResponse.
    /// </summary>
    public class AlipayPromoEventSendResponse : AopResponse
    {
        /// <summary>
        /// 接口调用结果：true,false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
