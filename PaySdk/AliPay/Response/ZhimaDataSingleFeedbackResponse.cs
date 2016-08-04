using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaDataSingleFeedbackResponse.
    /// </summary>
    public class ZhimaDataSingleFeedbackResponse : AopResponse
    {
        /// <summary>
        /// 数据反馈成功失败的标识
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
