using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMdataprodUserProfileGetResponse.
    /// </summary>
    public class AlipayMdataprodUserProfileGetResponse : AopResponse
    {
        /// <summary>
        /// 是否成功标志
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// 用户画像信息的json格式
        /// </summary>
        [XmlElement("user_profile_json")]
        public string UserProfileJson { get; set; }
    }
}
