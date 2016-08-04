using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAcquireOverseasSpotRefundResponse.
    /// </summary>
    public class AlipayAcquireOverseasSpotRefundResponse : AopResponse
    {
        /// <summary>
        /// On the partner’s payment request, the alipay system creates a transaction id to handle it.  The alipay_trans_id has one-one association with partner + partner_trans_id.
        /// </summary>
        [XmlElement("alipay_trans_id")]
        public string AlipayTransId { get; set; }

        /// <summary>
        /// refund currency
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// To describe the reason of the result_code when it is failed/unknown, leave it blank when result_code is success.
        /// </summary>
        [XmlElement("error")]
        public string Error { get; set; }

        /// <summary>
        /// It indicates that a request is accepted by Alipay gateway.  T for accepted
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// The refund order id on partner system.    partner_refund_id together with partner identify a refund transaction
        /// </summary>
        [XmlElement("partner_refund_id")]
        public string PartnerRefundId { get; set; }

        /// <summary>
        /// Equal to the partner_trans_id given in the request
        /// </summary>
        [XmlElement("partner_trans_id")]
        public string PartnerTransId { get; set; }

        /// <summary>
        /// Less than or equal to the original transaction amont and the left transaction amount if ever refunded.
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// To describe the response status of a request:  SUCCESS, FAILED, UNKNOW.
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
