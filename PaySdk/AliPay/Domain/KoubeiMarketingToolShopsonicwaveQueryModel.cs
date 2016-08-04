using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingToolShopsonicwaveQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolShopsonicwaveQueryModel : AopObject
    {
        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
