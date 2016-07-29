using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignCrowdCreateModel : AopObject
    {
        /// <summary>
        /// 圈人的条件
        /// </summary>
        [XmlElement("conditions")]
        public string Conditions { get; set; }

        /// <summary>
        /// 人群组的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作者类型PROVIDE表示是服务商，不传值表示是商家
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
