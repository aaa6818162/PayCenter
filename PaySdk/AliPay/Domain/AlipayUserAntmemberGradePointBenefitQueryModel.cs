using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntmemberGradePointBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntmemberGradePointBenefitQueryModel : AopObject
    {
        /// <summary>
        /// JSON数组的格式表示当前商户需要查询的权益配置的ID列表
        /// </summary>
        [XmlArray("benefit_ids")]
        [XmlArrayItem("string")]
        public List<string> BenefitIds { get; set; }

        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
