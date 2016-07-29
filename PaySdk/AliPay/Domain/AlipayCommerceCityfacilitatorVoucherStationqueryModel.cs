using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherStationqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorVoucherStationqueryModel : AopObject
    {
        /// <summary>
        /// 城市标准码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }
    }
}
