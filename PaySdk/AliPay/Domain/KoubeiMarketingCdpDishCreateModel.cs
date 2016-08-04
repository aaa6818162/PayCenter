using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpDishCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpDishCreateModel : AopObject
    {
        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 菜品名称 不能重复
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品图片，目前只支持传1个
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("picture")]
        public List<Picture> Pictures { get; set; }

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
