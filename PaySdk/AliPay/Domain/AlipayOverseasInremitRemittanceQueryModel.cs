using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasInremitRemittanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasInremitRemittanceQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝转账单交易号 transferNo
        /// </summary>
        [XmlElement("alipay_trans_id")]
        public string AlipayTransId { get; set; }

        /// <summary>
        /// 商户partner_id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
