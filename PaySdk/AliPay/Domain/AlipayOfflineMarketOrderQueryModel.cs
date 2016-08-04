using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketOrderQueryModel : AopObject
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
