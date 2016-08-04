using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpMenuDelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpMenuDelModel : AopObject
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [XmlElement("menu_id")]
        public string MenuId { get; set; }
    }
}
