using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherBatchqueryModel : AopObject
    {
        /// <summary>
        /// 城市标准码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝交易号列表
        /// </summary>
        [XmlArray("trade_nos")]
        [XmlArrayItem("string")]
        public List<string> TradeNos { get; set; }
    }
}
