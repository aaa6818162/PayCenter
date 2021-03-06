using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitTool Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitTool : AopObject
    {
        /// <summary>
        /// 招商结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 招商pid和pid对应的门第列表
        /// </summary>
        [XmlArray("pid_shops")]
        [XmlArrayItem("pid_shop_info")]
        public List<PidShopInfo> PidShops { get; set; }

        /// <summary>
        /// 招商开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
