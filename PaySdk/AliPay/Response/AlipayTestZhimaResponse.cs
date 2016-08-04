using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTestZhimaResponse.
    /// </summary>
    public class AlipayTestZhimaResponse : AopResponse
    {
        /// <summary>
        /// 分数
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
