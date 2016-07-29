using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignActivityOfflineModel : AopObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// "{\"key\"：\"value\"}"
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

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
        /// 下架原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
