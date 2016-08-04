using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitInviteeQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRecruitInviteeQueryResponse : AopResponse
    {
        /// <summary>
        /// 被邀请人总数量
        /// </summary>
        [XmlElement("invitee_count")]
        public string InviteeCount { get; set; }

        /// <summary>
        /// 被邀约商户信息
        /// </summary>
        [XmlArray("invitee_info")]
        [XmlArrayItem("recruit_invitee_info")]
        public List<RecruitInviteeInfo> InviteeInfo { get; set; }

        /// <summary>
        /// 招商方案id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
