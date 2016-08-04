using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntmemberBenefitBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntmemberBenefitBatchqueryModel : AopObject
    {
        /// <summary>
        /// JSON数组的格式表示当前商户需要查询的权益配置的ID列表
        /// </summary>
        [XmlArray("benefit_ids")]
        [XmlArrayItem("string")]
        public List<string> BenefitIds { get; set; }
    }
}
