using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherDetailModel : AopObject
    {
        /// <summary>
        /// 必填
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
