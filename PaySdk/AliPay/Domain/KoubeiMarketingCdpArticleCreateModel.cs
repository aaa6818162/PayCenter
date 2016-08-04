using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpArticleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpArticleCreateModel : AopObject
    {
        /// <summary>
        /// 作者简介
        /// </summary>
        [XmlElement("author_intro")]
        public string AuthorIntro { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        [XmlElement("cover")]
        public ArticlePicture Cover { get; set; }

        /// <summary>
        /// 文章简介
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 正文段落
        /// </summary>
        [XmlArray("paragraph_list")]
        [XmlArrayItem("article_paragraph")]
        public List<ArticleParagraph> ParagraphList { get; set; }

        /// <summary>
        /// 内容提供的机构
        /// </summary>
        [XmlElement("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 适用店铺列表，不能超过500个
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
