using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCdpArticleQueryResponse.
    /// </summary>
    public class KoubeiMarketingCdpArticleQueryResponse : AopResponse
    {
        /// <summary>
        /// 达人说文章的id
        /// </summary>
        [XmlElement("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 最后审核人
        /// </summary>
        [XmlElement("auditor")]
        public string Auditor { get; set; }

        /// <summary>
        /// 作者简介
        /// </summary>
        [XmlElement("author_intro")]
        public string AuthorIntro { get; set; }

        /// <summary>
        /// 作者名称
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        [XmlElement("cover")]
        public ArticlePicture Cover { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 文章简介
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 正文段落
        /// </summary>
        [XmlArray("paragraph_list")]
        [XmlArrayItem("article_paragraph")]
        public List<ArticleParagraph> ParagraphList { get; set; }

        /// <summary>
        /// 内容提供商
        /// </summary>
        [XmlElement("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// 文章的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// XXX文章
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 上传人
        /// </summary>
        [XmlElement("uploader")]
        public string Uploader { get; set; }
    }
}
