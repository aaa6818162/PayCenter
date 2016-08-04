using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRefundResponse.
    /// </summary>
    public class AlipayTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 用户的登录id
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化
        /// </summary>
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 退款支付时间
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 买家支付宝用户号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款返回的资金明细类型
        /// </summary>
        [XmlArray("refund_detail_item_list")]
        [XmlArrayItem("trade_fund_bill")]
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 本次发生的退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 交易在支付时候的门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 2013112011001004330000121536
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
