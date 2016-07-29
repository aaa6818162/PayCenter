using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Voucher Data Structure.
    /// </summary>
    [Serializable]
    public class Voucher : AopObject
    {
        /// <summary>
        /// 券副标题
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 券的说明条款
        /// </summary>
        [XmlArray("clause_terms")]
        [XmlArrayItem("clause_term")]
        public List<ClauseTerm> ClauseTerms { get; set; }

        /// <summary>
        /// 延迟生效信息
        /// </summary>
        [XmlElement("delay_info")]
        public DelayInfo DelayInfo { get; set; }

        /// <summary>
        /// 券说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 券的展示信息
        /// </summary>
        [XmlElement("display_config")]
        public DisplayConfig DisplayConfig { get; set; }

        /// <summary>
        /// 是否可转赠
        /// </summary>
        [XmlElement("donate_flag")]
        public string DonateFlag { get; set; }

        /// <summary>
        /// 券生效的方式
        /// </summary>
        [XmlElement("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 有效期的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 券的扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 单品信息
        /// </summary>
        [XmlElement("item_info")]
        public ItemInfo ItemInfo { get; set; }

        /// <summary>
        /// 券LOGO图片
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 最高优惠金额
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 相对有效期的值
        /// </summary>
        [XmlElement("relative_time")]
        public string RelativeTime { get; set; }

        /// <summary>
        /// 券有效期的开始时间，仅当validate_type为ABSOLUTE有效
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券的使用说明
        /// </summary>
        [XmlArray("use_instructions")]
        [XmlArrayItem("string")]
        public List<string> UseInstructions { get; set; }

        /// <summary>
        /// 券的使用规则信息
        /// </summary>
        [XmlElement("use_rule")]
        public UseRule UseRule { get; set; }

        /// <summary>
        /// 券有效期类型
        /// </summary>
        [XmlElement("validate_type")]
        public string ValidateType { get; set; }

        /// <summary>
        /// 券图片
        /// </summary>
        [XmlElement("voucher_img")]
        public string VoucherImg { get; set; }

        /// <summary>
        /// 券面额
        /// </summary>
        [XmlElement("worth_value")]
        public string WorthValue { get; set; }
    }
}
