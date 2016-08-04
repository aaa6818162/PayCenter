using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsExtInfo : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 结束服务时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开始服务时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
