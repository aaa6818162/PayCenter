using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceCrowdConditionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCrowdConditionQueryModel : AopObject
    {
        /// <summary>
        /// 通过规则组ID返回规则组信息
        /// </summary>
        [XmlElement("condition_id")]
        public string ConditionId { get; set; }
    }
}
