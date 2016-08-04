using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketIsvShopActionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketIsvShopActionQueryModel : AopObject
    {
        /// <summary>
        /// 商户操作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 用户操作实体具体信息（这里是菜品实体信息）,如果entiy 是shop_dish 则 actiond_detail_dish 为必填字段
        /// </summary>
        [XmlElement("actiond_detail_dish")]
        public IsvShopDish ActiondDetailDish { get; set; }

        /// <summary>
        /// 用户操作实体具体信息（这里是餐桌实体信息）,如果entiy 是shop_table 则 actiond_detail_shop 为必填字段
        /// </summary>
        [XmlElement("actiond_detail_shop")]
        public IsvShopTable ActiondDetailShop { get; set; }

        /// <summary>
        /// 商户操作行为发生的时间，格式必须是 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("date_time")]
        public string DateTime { get; set; }

        /// <summary>
        /// 操作对象的类型名字(shop_table、shop_dish)
        /// </summary>
        [XmlElement("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// 操作的店铺对象信息
        /// </summary>
        [XmlElement("outer_shop_do")]
        public OuterShopDO OuterShopDo { get; set; }
    }
}
