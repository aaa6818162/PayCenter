using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingDiscountActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingDiscountActivityCreateModel : AopObject
    {
        /// <summary>
        /// 活动基本信息
        /// </summary>
        [XmlElement("activity")]
        public ActivityDto Activity { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 活动奖品信息列表
        /// </summary>
        [XmlArray("pirze_list")]
        [XmlArrayItem("prize_dto")]
        public List<PrizeDto> PirzeList { get; set; }

        /// <summary>
        /// 投放信息
        /// </summary>
        [XmlElement("putin")]
        public PutinDto Putin { get; set; }
    }
}
