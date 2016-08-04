using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpMenuModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpMenuModifyModel : AopObject
    {
        /// <summary>
        /// 封面
        /// </summary>
        [XmlElement("cover")]
        public Picture Cover { get; set; }

        /// <summary>
        /// 菜品ids列表
        /// </summary>
        [XmlArray("dishes")]
        [XmlArrayItem("string")]
        public List<string> Dishes { get; set; }

        /// <summary>
        /// 菜单id
        /// </summary>
        [XmlElement("menu_id")]
        public string MenuId { get; set; }

        /// <summary>
        /// 适用门店列表ids 最多500个
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 菜单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
