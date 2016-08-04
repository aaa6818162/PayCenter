using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdSubmerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdSubmerchantQueryModel : AopObject
    {
        /// <summary>
        /// 商户外部编号
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商户识别号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
