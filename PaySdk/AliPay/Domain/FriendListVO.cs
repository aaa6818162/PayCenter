using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FriendListVO Data Structure.
    /// </summary>
    [Serializable]
    public class FriendListVO : AopObject
    {
        /// <summary>
        /// 头像的服务地址
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 是使用userid通过调用cifcommon的服务生成的
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 是否双向好友
        /// </summary>
        [XmlElement("real_friend")]
        public bool RealFriend { get; set; }

        /// <summary>
        /// 有可能包含emoji表情，业务方要注意编码
        /// </summary>
        [XmlElement("view_name")]
        public string ViewName { get; set; }
    }
}
