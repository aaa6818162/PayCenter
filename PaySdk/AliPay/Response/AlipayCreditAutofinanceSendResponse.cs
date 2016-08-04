using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceSendResponse.
    /// </summary>
    public class AlipayCreditAutofinanceSendResponse : AopResponse
    {
        /// <summary>
        /// 返回处理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
