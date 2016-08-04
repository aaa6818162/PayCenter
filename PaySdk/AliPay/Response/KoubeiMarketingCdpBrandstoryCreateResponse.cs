using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCdpBrandstoryCreateResponse.
    /// </summary>
    public class KoubeiMarketingCdpBrandstoryCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建生成的品牌故事id
        /// </summary>
        [XmlElement("brand_story_id")]
        public string BrandStoryId { get; set; }
    }
}
