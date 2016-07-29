using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainOrderStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainOrderStatusUpdateModel : AopObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 行业类目标识
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 状态: 1.确认收货, 2.服务验证
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
