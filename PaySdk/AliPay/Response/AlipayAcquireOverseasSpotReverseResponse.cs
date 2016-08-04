using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAcquireOverseasSpotReverseResponse.
    /// </summary>
    public class AlipayAcquireOverseasSpotReverseResponse : AopResponse
    {
        /// <summary>
        /// The time of the transaction has been paid.  Format：YYYYMMDDHHMMSS    Leave it blank when result_code is failed/unknown.
        /// </summary>
        [XmlElement("alipay_reverse_time")]
        public string AlipayReverseTime { get; set; }

        /// <summary>
        /// On the partner’s payment request, the alipay system creates a transaction id to handle it.  The alipay_trans_id has one-one association with partner + partner_trans_id.
        /// </summary>
        [XmlElement("alipay_trans_id")]
        public string AlipayTransId { get; set; }

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
        /// Equal to the partner_trans_id given in the request
        /// </summary>
        [XmlElement("partner_trans_id")]
        public string PartnerTransId { get; set; }

        /// <summary>
        /// To describe the response status of a request:  SUCCESS, FAILED, UNKNOW.
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
