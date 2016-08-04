using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherListResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherListResponse : AopResponse
    {
        /// <summary>
        /// 券工具信息
        /// </summary>
        [XmlArray("voucher_campaign_tool_infos")]
        [XmlArrayItem("voucher_campaign_tool_info")]
        public List<VoucherCampaignToolInfo> VoucherCampaignToolInfos { get; set; }
    }
}
