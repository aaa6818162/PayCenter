using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseRuleDTO : AopObject
    {
        /// <summary>
        /// 可用时段
        /// </summary>
        [XmlElement("available_time")]
        public AvailableVoucherTimeDTO AvailableTime { get; set; }

        /// <summary>
        /// 延迟信息
        /// </summary>
        [XmlElement("delay_info")]
        public EffectiveDelayInfoDTO DelayInfo { get; set; }

        /// <summary>
        /// 生效类型,IMMEDIATELY:立即生效,DELAY:延迟生效
        /// </summary>
        [XmlElement("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 不可用时段
        /// </summary>
        [XmlElement("forbidden_time")]
        public ForbiddenVoucherTimeDTO ForbiddenTime { get; set; }

        /// <summary>
        /// 最低消费金额
        /// </summary>
        [XmlElement("min_consume")]
        public string MinConsume { get; set; }

        /// <summary>
        /// 适用门店类别
        /// </summary>
        [XmlArray("suit_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitShops { get; set; }
    }
}
