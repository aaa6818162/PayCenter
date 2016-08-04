using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDTO : AopObject
    {
        /// <summary>
        /// 券描述
        /// </summary>
        [XmlArray("clause_terms")]
        [XmlArrayItem("voucher_term_d_t_o")]
        public List<VoucherTermDTO> ClauseTerms { get; set; }

        /// <summary>
        /// 券说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 是否可转赠
        /// </summary>
        [XmlElement("donate_flag")]
        public string DonateFlag { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 单品信息
        /// </summary>
        [XmlElement("item_info")]
        public ItemInfoDTO ItemInfo { get; set; }

        /// <summary>
        /// 券logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 最高优惠金额
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 相对时间
        /// </summary>
        [XmlElement("relative_time")]
        public string RelativeTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 券类型.EXCHANGE:兑换券,MONEY:代金券,RATE:折扣券
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        [XmlArray("use_instructions")]
        [XmlArrayItem("string")]
        public List<string> UseInstructions { get; set; }

        /// <summary>
        /// 核销规则
        /// </summary>
        [XmlElement("use_rule")]
        public VoucherUseRuleDTO UseRule { get; set; }

        /// <summary>
        /// 有效期类型,RELATIVE:相对时间,FIXED:固定时间
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
