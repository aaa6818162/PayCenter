using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpShopenvModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpShopenvModifyModel : AopObject
    {
        /// <summary>
        /// 环境图名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 环境图id
        /// </summary>
        [XmlElement("shop_env_id")]
        public string ShopEnvId { get; set; }

        /// <summary>
        /// 适用的门店列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
