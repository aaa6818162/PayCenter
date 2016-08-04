using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthZhimaDataBatchFeedbackResponse.
    /// </summary>
    public class AlipayOpenAuthZhimaDataBatchFeedbackResponse : AopResponse
    {
        /// <summary>
        /// 业务执行结果
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }
    }
}
