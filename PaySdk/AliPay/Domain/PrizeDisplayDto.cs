using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeDisplayDto Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeDisplayDto : AopObject
    {
        /// <summary>
        /// 奖品描述
        /// </summary>
        [XmlElement("prize_desc")]
        public string PrizeDesc { get; set; }

        /// <summary>
        /// 奖品详情图片id
        /// </summary>
        [XmlElement("prize_img")]
        public string PrizeImg { get; set; }

        /// <summary>
        /// 奖品logo图片id
        /// </summary>
        [XmlElement("prize_logo")]
        public string PrizeLogo { get; set; }

        /// <summary>
        /// 9.0优惠券
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品使用须知
        /// </summary>
        [XmlArray("prize_terms")]
        [XmlArrayItem("string")]
        public List<string> PrizeTerms { get; set; }

        /// <summary>
        /// 商品sku描述
        /// </summary>
        [XmlElement("sku_desc")]
        public string SkuDesc { get; set; }

        /// <summary>
        /// 商品sku图片ids
        /// </summary>
        [XmlArray("sku_imgs")]
        [XmlArrayItem("string")]
        public List<string> SkuImgs { get; set; }
    }
}
