using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetVoucherVoucherDirectuseResponse.
    /// </summary>
    public class AlipayAssetVoucherVoucherDirectuseResponse : AopResponse
    {
        /// <summary>
        /// 被核销的券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
