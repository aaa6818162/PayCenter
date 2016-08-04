using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCrowdConditionQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceCrowdConditionQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的Condition数据
        /// </summary>
        [XmlElement("condition")]
        public string Condition { get; set; }
    }
}
