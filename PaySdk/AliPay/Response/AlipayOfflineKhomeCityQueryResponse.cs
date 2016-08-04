using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineKhomeCityQueryResponse.
    /// </summary>
    public class AlipayOfflineKhomeCityQueryResponse : AopResponse
    {
        /// <summary>
        /// 城市列表，每个城市包括城市编码、城市名以及城市所有的区信息
        /// </summary>
        [XmlArray("city_list")]
        [XmlArrayItem("city_info")]
        public List<CityInfo> CityList { get; set; }
    }
}
