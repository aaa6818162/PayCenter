using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpArticleQuerybyshopidModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpArticleQuerybyshopidModel : AopObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
