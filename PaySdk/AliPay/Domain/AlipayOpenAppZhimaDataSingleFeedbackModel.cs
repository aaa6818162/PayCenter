using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppZhimaDataSingleFeedbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppZhimaDataSingleFeedbackModel : AopObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("biz_ext_params")]
        public string BizExtParams { get; set; }

        /// <summary>
        /// 数据体
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 18位身份证号码
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 芝麻商户录入时的数据类型
        /// </summary>
        [XmlElement("type_id")]
        public string TypeId { get; set; }
    }
}
