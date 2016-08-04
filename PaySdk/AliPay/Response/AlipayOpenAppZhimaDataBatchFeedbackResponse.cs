using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppZhimaDataBatchFeedbackResponse.
    /// </summary>
    public class AlipayOpenAppZhimaDataBatchFeedbackResponse : AopResponse
    {
        /// <summary>
        /// 业务调用是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }
    }
}
