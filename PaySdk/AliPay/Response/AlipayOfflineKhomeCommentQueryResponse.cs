using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineKhomeCommentQueryResponse.
    /// </summary>
    public class AlipayOfflineKhomeCommentQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单评价内容
        /// </summary>
        [XmlElement("comment_content")]
        public string CommentContent { get; set; }

        /// <summary>
        /// 订单评价图片
        /// </summary>
        [XmlArray("comment_imgs")]
        [XmlArrayItem("string")]
        public List<string> CommentImgs { get; set; }

        /// <summary>
        /// 订单评价标签
        /// </summary>
        [XmlArray("comment_tags")]
        [XmlArrayItem("string")]
        public List<string> CommentTags { get; set; }

        /// <summary>
        /// 订单评价时间
        /// </summary>
        [XmlElement("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 评价分数
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
