using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceCrowdCountModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCrowdCountModel : AopObject
    {
        /// <summary>
        /// 按Condition统计人数
        /// </summary>
        [XmlElement("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 传入condition_id则按照condition_id对应的rule来查询
        /// </summary>
        [XmlElement("condition_id")]
        public long ConditionId { get; set; }
    }
}
