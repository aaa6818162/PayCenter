using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeDto Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeDto : AopObject
    {
        /// <summary>
        /// 奖品展示信息
        /// </summary>
        [XmlElement("display_info")]
        public PrizeDisplayDto DisplayInfo { get; set; }

        /// <summary>
        /// 奖品资金信息
        /// </summary>
        [XmlElement("funds_info")]
        public PrizeFundDto FundsInfo { get; set; }

        /// <summary>
        /// 奖品使用信息
        /// </summary>
        [XmlElement("use_info")]
        public PrizeUseDto UseInfo { get; set; }
    }
}
