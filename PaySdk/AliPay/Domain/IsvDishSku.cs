using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvDishSku Data Structure.
    /// </summary>
    [Serializable]
    public class IsvDishSku : AopObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("p_name")]
        public string PName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("p_value")]
        public string PValue { get; set; }

        /// <summary>
        /// 菜品价格   单个SKU价格 单位是分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 菜品库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
