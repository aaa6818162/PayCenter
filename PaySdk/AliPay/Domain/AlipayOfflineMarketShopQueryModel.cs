using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopQueryModel : AopObject
    {
        /// <summary>
        /// ISV，默认为ISV，可以不填写。服务商：PROVIDER；系统集成商
        /// </summary>
        [XmlElement("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 支付宝门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
