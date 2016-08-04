using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaDataSingleFeedbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaDataSingleFeedbackModel : AopObject
    {
        /// <summary>
        /// 反馈的扩展字段
        /// </summary>
        [XmlElement("biz_ext_params")]
        public string BizExtParams { get; set; }

        /// <summary>
        /// 反馈数据的json字符串
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 反馈数据针对用户的身份标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 反馈的数据类型
        /// </summary>
        [XmlElement("type_id")]
        public string TypeId { get; set; }
    }
}
