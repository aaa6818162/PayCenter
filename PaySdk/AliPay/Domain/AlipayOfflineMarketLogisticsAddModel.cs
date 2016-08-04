using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLogisticsAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLogisticsAddModel : AopObject
    {
        /// <summary>
        /// 外部商户物流单号
        /// </summary>
        [XmlElement("external_logistics_id")]
        public string ExternalLogisticsId { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_desc")]
        public string LogisticsDesc { get; set; }

        /// <summary>
        /// 物流时间
        /// </summary>
        [XmlElement("logistics_time")]
        public string LogisticsTime { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
