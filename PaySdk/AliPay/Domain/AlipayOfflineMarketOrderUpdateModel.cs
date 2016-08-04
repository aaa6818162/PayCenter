using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketOrderUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketOrderUpdateModel : AopObject
    {
        /// <summary>
        /// 服务结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 第三方手艺人id
        /// </summary>
        [XmlElement("external_sp_id")]
        public string ExternalSpId { get; set; }

        /// <summary>
        /// 修改订单信息的备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 开始服务时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
