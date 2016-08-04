using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceCrowdConditionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCrowdConditionCreateModel : AopObject
    {
        /// <summary>
        /// 规则组的操作符
        /// </summary>
        [XmlElement("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 如果Condition_id 不为空则为update操作
        /// </summary>
        [XmlElement("condition_id")]
        public long ConditionId { get; set; }
    }
}
