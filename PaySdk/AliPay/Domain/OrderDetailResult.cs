using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDetailResult : AopObject
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单明细的合作伙伴ID（2088开头的16位纯数字）
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态，有以下几种取值：  1. TRADE_SUCCESS：付款成功  2. TRADE_FINISHED：交易完成  3. WAIT_BUYER_PAY：等待支付  4. TRADE_CLOSED：交易关闭
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
