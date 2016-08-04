using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicContactFollowListResponse.
    /// </summary>
    public class AlipayMobileStdPublicContactFollowListResponse : AopResponse
    {
        /// <summary>
        /// 联系人关注者列表
        /// </summary>
        [XmlArray("contact_follow_list")]
        [XmlArrayItem("string")]
        public List<string> ContactFollowList { get; set; }
    }
}
