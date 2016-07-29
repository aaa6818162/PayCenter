using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignTagsQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignTagsQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询成功时返回人群标签信息查询失败时为空
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }
    }
}
