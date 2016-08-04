using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitInviteeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitInviteeInfo : AopObject
    {
        /// <summary>
        /// 确认类型
        /// </summary>
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 已确认的门店数量
        /// </summary>
        [XmlElement("confirmed_shop_count")]
        public string ConfirmedShopCount { get; set; }

        /// <summary>
        /// 被邀请人id
        /// </summary>
        [XmlElement("invitee")]
        public string Invitee { get; set; }

        /// <summary>
        /// 被邀请人类型
        /// </summary>
        [XmlElement("invitee_type")]
        public string InviteeType { get; set; }
    }
}
