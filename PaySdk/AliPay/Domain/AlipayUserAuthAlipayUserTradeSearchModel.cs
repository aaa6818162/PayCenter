using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthAlipayUserTradeSearchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthAlipayUserTradeSearchModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号，为空查询所有记录
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 结束时间。与开始时间间隔在七天之内
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户订单号，为空查询所有记录
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单来源，为空查询所有来源。淘宝(TAOBAO)，支付宝(ALIPAY)，其它(OTHER)
        /// </summary>
        [XmlElement("order_from")]
        public string OrderFrom { get; set; }

        /// <summary>
        /// 订单状态，为空查询所有状态订单
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型，为空查询所有类型订单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数; 默认值1
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页获取条数。最大值500。
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 开始时间，时间必须是今天范围之内。格式为yyyy-MM-dd HH:mm:ss，精确到秒
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
