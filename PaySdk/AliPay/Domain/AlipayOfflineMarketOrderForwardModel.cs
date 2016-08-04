using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketOrderForwardModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketOrderForwardModel : AopObject
    {
        /// <summary>
        /// 操作备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("order_action")]
        public string OrderAction { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
