using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignListQueryModel : AopObject
    {
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
        /// 页码
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [XmlArray("query_criterias")]
        [XmlArrayItem("condition")]
        public List<Condition> QueryCriterias { get; set; }
    }
}
