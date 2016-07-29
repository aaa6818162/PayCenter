using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OuterShopDO Data Structure.
    /// </summary>
    [Serializable]
    public class OuterShopDO : AopObject
    {
        /// <summary>
        /// 合作商户ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 支付宝店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 合作商户类型 （mike、_2dFire）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}