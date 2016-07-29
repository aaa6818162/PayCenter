using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayTradeSettleResponse : AopResponse
    {
        /// <summary>
        /// 支付宝脱机交易处理结果列表
        /// </summary>
        [XmlElement("result_list")]
        public AlipayOfflineTradeResult ResultList { get; set; }
    }
}
