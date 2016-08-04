using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppZhimaDataSingleFeedbackResponse.
    /// </summary>
    public class AlipayOpenAppZhimaDataSingleFeedbackResponse : AopResponse
    {
        /// <summary>
        /// 接口调用结果
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
