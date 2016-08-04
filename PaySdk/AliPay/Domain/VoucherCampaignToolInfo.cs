using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherCampaignToolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherCampaignToolInfo : AopObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [XmlElement("budget_info")]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 获取规则
        /// </summary>
        [XmlElement("get_rule")]
        public GetRuleInfo GetRule { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [XmlElement("voucher_info")]
        public VoucherInfo VoucherInfo { get; set; }
    }
}
