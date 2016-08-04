using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CityInfo : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区列表
        /// </summary>
        [XmlArray("district_list")]
        [XmlArrayItem("district_info")]
        public List<DistrictInfo> DistrictList { get; set; }
    }
}
