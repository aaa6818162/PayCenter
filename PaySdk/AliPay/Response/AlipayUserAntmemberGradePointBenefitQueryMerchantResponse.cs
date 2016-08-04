using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntmemberGradePointBenefitQueryMerchantResponse.
    /// </summary>
    public class AlipayUserAntmemberGradePointBenefitQueryMerchantResponse : AopResponse
    {
        /// <summary>
        /// 用户信息和权益配置全量信息查询结果，包括用户等级、积分余额以及当前应用和入参的benefit_ids对应的权益配置的积分和等级折扣积分列表
        /// </summary>
        [XmlElement("user_info_and_benefit_query_result")]
        public UserInfoAndBenefitQueryResult UserInfoAndBenefitQueryResult { get; set; }
    }
}
