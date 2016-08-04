using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpBrandstoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpBrandstoryModifyModel : AopObject
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 修改的时候不传就代表删除
        /// </summary>
        [XmlElement("cover")]
        public Picture Cover { get; set; }

        /// <summary>
        /// 正文段落列表
        /// </summary>
        [XmlArray("paragraph_list")]
        [XmlArrayItem("paragraph")]
        public List<Paragraph> ParagraphList { get; set; }

        /// <summary>
        /// 适用门店列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 视频
        /// </summary>
        [XmlElement("video")]
        public Video Video { get; set; }
    }
}
