using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCreateModel : AopObject
    {
        /// <summary>
        /// 活动预算
        /// </summary>
        [XmlElement("budget_info")]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 活动限制信息
        /// </summary>
        [XmlElement("constraint_info")]
        public ConstraintInfo ConstraintInfo { get; set; }

        /// <summary>
        /// 活动详细说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动的扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部批次ID
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 营销工具集
        /// </summary>
        [XmlArray("promo_tools")]
        [XmlArrayItem("promo_tool")]
        public List<PromoTool> PromoTools { get; set; }

        /// <summary>
        /// 投放渠道集
        /// </summary>
        [XmlArray("publish_channels")]
        [XmlArrayItem("publish_channel")]
        public List<PublishChannel> PublishChannels { get; set; }

        /// <summary>
        /// 招商工具信息
        /// </summary>
        [XmlElement("recruit_tool")]
        public RecruitTool RecruitTool { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
