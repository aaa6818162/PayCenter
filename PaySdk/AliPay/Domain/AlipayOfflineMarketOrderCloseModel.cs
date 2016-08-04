using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketOrderCloseModel : AopObject
    {
        /// <summary>
        /// 取消订单的原因
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
