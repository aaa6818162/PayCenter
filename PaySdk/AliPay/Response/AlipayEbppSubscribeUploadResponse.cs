using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppSubscribeUploadResponse.
    /// </summary>
    public class AlipayEbppSubscribeUploadResponse : AopResponse
    {
        /// <summary>
        /// 出账机构简称如杭州水务HZWATEr
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 业务类型，如缴费JF
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 子业务类型如水费WATER
        /// </summary>
        [XmlElement("sub_order_type")]
        public string SubOrderType { get; set; }
    }
}
