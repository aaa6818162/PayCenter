using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceConditionRemoveResponse.
    /// </summary>
    public class AlipayDataDataserviceConditionRemoveResponse : AopResponse
    {
        /// <summary>
        /// 返回结果，删除成功返回SUCCESS，删除失败返回FAILED
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
