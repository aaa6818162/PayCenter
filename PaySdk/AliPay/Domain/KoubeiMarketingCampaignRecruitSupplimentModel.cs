using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitSupplimentModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignRecruitSupplimentModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// MER 代表商户自己操作  MER_OPERATOR 代表商户操作员操作  PROVIDER 代表服务商操作  PROVIDER_STAFF 代表服务商员工操作
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 追加商户和门店的列表，里面是一个Pid带门店列表
        /// </summary>
        [XmlArray("pid_shops")]
        [XmlArrayItem("pid_shop_info")]
        public List<PidShopInfo> PidShops { get; set; }

        /// <summary>
        /// 追加到具体的券的ID
        /// </summary>
        [XmlElement("voucher_no")]
        public string VoucherNo { get; set; }
    }
}
