using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeFundDto Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeFundDto : AopObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [XmlElement("budget")]
        public BudgetInfo Budget { get; set; }

        /// <summary>
        /// 奖池编号
        /// </summary>
        [XmlElement("prize_pool_id")]
        public string PrizePoolId { get; set; }

        /// <summary>
        /// 奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
