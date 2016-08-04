using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpBrandstoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpBrandstoryCreateModel : AopObject
    {
        /// <summary>
        /// 封面图片名称
        /// </summary>
        [XmlElement("cover_name")]
        public string CoverName { get; set; }

        /// <summary>
        /// 图片上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("cover_pic_location")]
        public string CoverPicLocation { get; set; }

        /// <summary>
        /// 正文段落列表
        /// </summary>
        [XmlArray("paragraph_list")]
        [XmlArrayItem("paragraph")]
        public List<Paragraph> ParagraphList { get; set; }

        /// <summary>
        /// 适用门店列表 必填  长度500
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
        /// 图片上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("video_location")]
        public string VideoLocation { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [XmlElement("video_name")]
        public string VideoName { get; set; }
    }
}
