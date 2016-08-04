using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingQrcodeQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备商订单id
        /// </summary>
        [XmlElement("equipment_order_id")]
        public string EquipmentOrderId { get; set; }

        /// <summary>
        /// 缴费金额单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("money")]
        public string Money { get; set; }

        /// <summary>
        /// 1:在车场，尚未缴费  2:在车场，免费离场期  3:在车场，需要续费  4:在车场，本次免费
        /// </summary>
        [XmlElement("parking_state")]
        public string ParkingState { get; set; }

        /// <summary>
        /// 离场时间限制，默认分钟
        /// </summary>
        [XmlElement("time_limit")]
        public string TimeLimit { get; set; }
    }
}
