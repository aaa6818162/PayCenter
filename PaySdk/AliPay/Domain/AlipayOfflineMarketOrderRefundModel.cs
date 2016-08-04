using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketOrderRefundModel : AopObject
    {
        /// <summary>
        /// 外部退款id，用来控制幂等
        /// </summary>
        [XmlElement("external_refund_id")]
        public string ExternalRefundId { get; set; }

        /// <summary>
        /// 退款描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款金额，单位为元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 如果全额退款，可不传，如果部分退款，必须带上明细。退款明细，如：  [{“item_order_no”:11,”refund_amount”:10.0},…]
        /// </summary>
        [XmlArray("refund_details")]
        [XmlArrayItem("refund_detail_request")]
        public List<RefundDetailRequest> RefundDetails { get; set; }
    }
}
