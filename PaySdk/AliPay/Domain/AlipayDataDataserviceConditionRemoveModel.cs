using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceConditionRemoveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceConditionRemoveModel : AopObject
    {
        /// <summary>
        /// 删除圈人规则组
        /// </summary>
        [XmlElement("condition_id")]
        public long ConditionId { get; set; }
    }
}
