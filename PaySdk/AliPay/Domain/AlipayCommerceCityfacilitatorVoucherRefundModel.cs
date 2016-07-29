using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherRefundModel : AopObject
    {
        /// <summary>
        /// 城市标准码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
