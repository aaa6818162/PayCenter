using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceCrowdDataProfileModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCrowdDataProfileModel : AopObject
    {
        /// <summary>
        /// 人群规则分组ID
        /// </summary>
        [XmlElement("condition_id")]
        public long ConditionId { get; set; }

        /// <summary>
        /// 统计标签值，多个值以半角竖线|分割
        /// </summary>
        [XmlElement("tag_codes")]
        public string TagCodes { get; set; }
    }
}
