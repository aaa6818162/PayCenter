using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceMonitorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceMonitorQueryModel : AopObject
    {
        /// <summary>
        /// 业务标识，目前包含4种类型：  user_age_data：参与的用户年龄分布  city_top_data：国内参与城市排名  city_light_data：地图城市亮度情况  city_fly_line_data：飞线数据
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
