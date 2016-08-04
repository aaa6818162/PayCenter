using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSettleRequestPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSettleRequestPojo : AopObject
    {
        /// <summary>
        /// 商户结算请求流水号，一次结算请求对应一个结算请求流水号。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细信息
        /// </summary>
        [XmlArray("royalty_parameters")]
        [XmlArrayItem("open_api_royalty_detail_info_pojo")]
        public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。最长64位。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
