using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCdpArticleCreateResponse.
    /// </summary>
    public class KoubeiMarketingCdpArticleCreateResponse : AopResponse
    {
        /// <summary>
        /// 上传后生成的id
        /// </summary>
        [XmlElement("article_id")]
        public string ArticleId { get; set; }
    }
}
