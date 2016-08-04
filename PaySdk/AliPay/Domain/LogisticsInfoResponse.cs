using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsInfoResponse : AopObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public LogisticsExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 纬度，火星坐标
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，火星坐标
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
