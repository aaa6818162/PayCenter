using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeUseDto Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeUseDto : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("discount_sku_num")]
        public string DiscountSkuNum { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("prize_end_time")]
        public string PrizeEndTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("prize_start_time")]
        public string PrizeStartTime { get; set; }

        /// <summary>
        /// 奖品适用门店
        /// </summary>
        [XmlArray("prize_suitable_shops")]
        [XmlArrayItem("string")]
        public List<string> PrizeSuitableShops { get; set; }

        /// <summary>
        /// 奖品sku
        /// </summary>
        [XmlArray("prize_suitable_sku")]
        [XmlArrayItem("string")]
        public List<string> PrizeSuitableSku { get; set; }

        /// <summary>
        /// FIX
        /// </summary>
        [XmlElement("prize_use_time_mode")]
        public string PrizeUseTimeMode { get; set; }

        /// <summary>
        /// 单品最低消费个数
        /// </summary>
        [XmlElement("threshold_each_sku_num")]
        public string ThresholdEachSkuNum { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("threshold_order_amount")]
        public string ThresholdOrderAmount { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [XmlArray("use_mode")]
        [XmlArrayItem("string")]
        public List<string> UseMode { get; set; }
    }
}
