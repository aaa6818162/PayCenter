using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UseRule Data Structure.
    /// </summary>
    [Serializable]
    public class UseRule : AopObject
    {
        /// <summary>
        /// 券的扩展属性
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券的不可用时间
        /// </summary>
        [XmlElement("forbidden_time")]
        public ForbbidenTime ForbiddenTime { get; set; }

        /// <summary>
        /// 最低消费金额
        /// </summary>
        [XmlElement("min_consume")]
        public string MinConsume { get; set; }

        /// <summary>
        /// 券适用的单品列表
        /// </summary>
        [XmlElement("suit_items")]
        public string SuitItems { get; set; }

        /// <summary>
        /// 券适用的门店列表
        /// </summary>
        [XmlArray("suit_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 券可用时间段
        /// </summary>
        [XmlArray("use_time")]
        [XmlArrayItem("use_time")]
        public List<UseTime> UseTime { get; set; }
    }
}
