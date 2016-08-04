using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInfoDTO : AopObject
    {
        /// <summary>
        /// 单品图片
        /// </summary>
        [XmlElement("item_head_img")]
        public string ItemHeadImg { get; set; }

        /// <summary>
        /// 单品限制集
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 单品图片集
        /// </summary>
        [XmlArray("item_imgs")]
        [XmlArrayItem("string")]
        public List<string> ItemImgs { get; set; }

        /// <summary>
        /// 单品跳转链接
        /// </summary>
        [XmlElement("item_link")]
        public string ItemLink { get; set; }

        /// <summary>
        /// 单品说明
        /// </summary>
        [XmlElement("item_text")]
        public string ItemText { get; set; }

        /// <summary>
        /// 最高优惠商品件数
        /// </summary>
        [XmlElement("max_discount_num")]
        public string MaxDiscountNum { get; set; }

        /// <summary>
        /// 最低购买商品件数
        /// </summary>
        [XmlElement("min_consume_num")]
        public string MinConsumeNum { get; set; }

        /// <summary>
        /// 单品价格
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }
    }
}
