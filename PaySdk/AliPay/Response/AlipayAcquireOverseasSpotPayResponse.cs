using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAcquireOverseasSpotPayResponse.
    /// </summary>
    public class AlipayAcquireOverseasSpotPayResponse : AopResponse
    {
        /// <summary>
        /// The buyer’s Alipay login Id, the id might be an email or mobile number.  The id is partially masked for privacy
        /// </summary>
        [XmlElement("alipay_buyer_login_id")]
        public string AlipayBuyerLoginId { get; set; }

        /// <summary>
        /// On the partner’s payment request, the alipay system creates a transaction id to handle it.  The alipay_trans_id has one-one association with partner + partner_trans_id
        /// </summary>
        [XmlElement("alipay_trans_id")]
        public string AlipayTransId { get; set; }

        /// <summary>
        /// The currency used for labeling the price of the transaction;     Refer to the acronym of currency table
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// To describe the reason of the result_code when it is failed/unknown, leave it blank when result_code is success.
        /// </summary>
        [XmlElement("error")]
        public string Error { get; set; }

        /// <summary>
        /// The rate of conversion the currency given in the request to CNY.  The conversion happens at the time when Alipay’s trade order is created.
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// It indicates that a request is rejected by Alipay gateway.F for rejected
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

        /// <summary>
        /// the transaction amount in the currency given above;    Range: 0.01-100000000.00. Two digits after decimal point.
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// Transaction amount in CNY.  It is the exact amount that the buyer has payed
        /// </summary>
        [XmlElement("trans_amount_cny")]
        public string TransAmountCny { get; set; }
    }
}
