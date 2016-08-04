using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpShopenvDelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpShopenvDelModel : AopObject
    {
        /// <summary>
        /// 环境图id
        /// </summary>
        [XmlElement("shop_env_id")]
        public string ShopEnvId { get; set; }
    }
}
