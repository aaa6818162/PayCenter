using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpShopenvCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpShopenvCreateModel : AopObject
    {
        /// <summary>
        /// 环境图名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片列表, 目前只支持1张
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("picture")]
        public List<Picture> Pictures { get; set; }

        /// <summary>
        /// 环境图适用的门店列表，最多支持500
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
