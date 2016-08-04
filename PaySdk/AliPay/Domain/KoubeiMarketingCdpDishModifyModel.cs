using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpDishModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpDishModifyModel : AopObject
    {
        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品价格 单位 元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 菜品标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("dish_tag")]
        public List<DishTag> Tags { get; set; }
    }
}
