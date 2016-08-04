using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCdpMenuCreateResponse.
    /// </summary>
    public class KoubeiMarketingCdpMenuCreateResponse : AopResponse
    {
        /// <summary>
        /// 保存后生成的id
        /// </summary>
        [XmlElement("menu_id")]
        public string MenuId { get; set; }
    }
}
