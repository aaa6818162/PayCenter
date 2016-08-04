using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCdpDishDelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCdpDishDelModel : AopObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }
    }
}
