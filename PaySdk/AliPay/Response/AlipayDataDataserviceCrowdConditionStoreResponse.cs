using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCrowdConditionStoreResponse.
    /// </summary>
    public class AlipayDataDataserviceCrowdConditionStoreResponse : AopResponse
    {
        /// <summary>
        /// 创建完规则组后的系统返回的规则组ID
        /// </summary>
        [XmlElement("condition_id")]
        public long ConditionId { get; set; }
    }
}
