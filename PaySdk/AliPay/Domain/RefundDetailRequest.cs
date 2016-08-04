using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundDetailRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RefundDetailRequest : AopObject
    {
        /// <summary>
        /// 商品子订单号
        /// </summary>
        [XmlElement("item_order_no")]
        public string ItemOrderNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
