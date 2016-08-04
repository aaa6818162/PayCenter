using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MicroPayNotify Data Structure.
    /// </summary>
    [Serializable]
    public class MicroPayNotify : AopObject
    {
        /// <summary>
        /// 支付宝冻结订单单据号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 单据创建时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商户冻结订单单据号（不超过32位，唯一）
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 操作类型（冻结、解冻、支付）
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 消息主题
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }

        /// <summary>
        /// 支付宝支付订单单据号
        /// </summary>
        [XmlElement("transfer_order_no")]
        public string TransferOrderNo { get; set; }

        /// <summary>
        /// 商户支付订单单据号（不超过32位，唯一）
        /// </summary>
        [XmlElement("transfer_out_order_no")]
        public string TransferOutOrderNo { get; set; }
    }
}
