using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherDetailResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherDetailResponse : AopResponse
    {
        /// <summary>
        /// 返回具体的券工具信息
        /// </summary>
        [XmlElement("voucher_campaign_tool")]
        public VoucherCampaignToolInfo VoucherCampaignTool { get; set; }
    }
}
