using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicStdMockPlaintApiResponse.
    /// </summary>
    public class AlipayMobilePublicStdMockPlaintApiResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("count_items")]
        public long CountItems { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("happen_time")]
        public string HappenTime { get; set; }

        /// <summary>
        /// 1.2
        /// </summary>
        [XmlElement("price_num")]
        public string PriceNum { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [XmlElement("right")]
        public bool Right { get; set; }

        /// <summary>
        /// XXXX
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
