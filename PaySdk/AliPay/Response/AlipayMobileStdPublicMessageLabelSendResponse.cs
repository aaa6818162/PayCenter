using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMessageLabelSendResponse.
    /// </summary>
    public class AlipayMobileStdPublicMessageLabelSendResponse : AopResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
