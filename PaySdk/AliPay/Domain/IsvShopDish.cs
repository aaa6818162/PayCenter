using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvShopDish Data Structure.
    /// </summary>
    [Serializable]
    public class IsvShopDish : AopObject
    {
        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 菜品的SKU结果
        /// </summary>
        [XmlArray("dish_sku_list")]
        [XmlArrayItem("isv_dish_sku")]
        public List<IsvDishSku> DishSkuList { get; set; }

        /// <summary>
        /// 菜品分类ID
        /// </summary>
        [XmlElement("dish_type_id")]
        public string DishTypeId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("dish_type_name")]
        public string DishTypeName { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [XmlElement("outer_dish_id")]
        public string OuterDishId { get; set; }

        /// <summary>
        /// 商品图片，可以上传多个
        /// </summary>
        [XmlArray("pict")]
        [XmlArrayItem("string")]
        public List<string> Pict { get; set; }

        /// <summary>
        /// 菜品价格，单位是分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 菜品排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 菜品单位（斤、份）
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
