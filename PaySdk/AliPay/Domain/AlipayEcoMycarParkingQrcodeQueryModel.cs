using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingQrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingQrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 设备商是否下单标志
        /// </summary>
        [XmlElement("creat_order_flag")]
        public string CreatOrderFlag { get; set; }

        /// <summary>
        /// 停车场id
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
