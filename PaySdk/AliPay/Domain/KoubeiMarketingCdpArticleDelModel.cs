using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpArticleDelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpArticleDelModel : AopObject
    {
        /// <summary>
        /// 达人说文章记录id
        /// </summary>
        [XmlElement("article_id")]
        public string ArticleId { get; set; }
    }
}
