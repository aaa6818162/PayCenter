using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBaitiaoprodSellerQueryResponse.
    /// </summary>
    public class AlipayBaitiaoprodSellerQueryResponse : AopResponse
    {
        /// <summary>
        /// 卖家是否还有未完结的订单
        /// </summary>
        [XmlElement("has_unfinished_order")]
        public bool HasUnfinishedOrder { get; set; }

        /// <summary>
        /// 卖家是否在“余额宝分期付”服务签约中
        /// </summary>
        [XmlElement("in_service")]
        public bool InService { get; set; }
    }
}
