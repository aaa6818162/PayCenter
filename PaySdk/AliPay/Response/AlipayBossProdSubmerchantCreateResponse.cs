using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdSubmerchantCreateResponse.
    /// </summary>
    public class AlipayBossProdSubmerchantCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户识别号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
