using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppZhimaCreditShareriskGetResponse.
    /// </summary>
    public class AlipayOpenAppZhimaCreditShareriskGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户详细信息
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("share_risk_detail")]
        public List<ShareRiskDetail> Details { get; set; }

        /// <summary>
        /// 最近一个月该用户被查询次数
        /// </summary>
        [XmlElement("stat_month")]
        public long StatMonth { get; set; }

        /// <summary>
        /// 最近三个月该用户被查询次数
        /// </summary>
        [XmlElement("stat_quarter")]
        public long StatQuarter { get; set; }

        /// <summary>
        /// 最近3天该用户被查询次数
        /// </summary>
        [XmlElement("stat_three_day")]
        public long StatThreeDay { get; set; }

        /// <summary>
        /// 最近7天该用户被查询次数
        /// </summary>
        [XmlElement("stat_week")]
        public long StatWeek { get; set; }
    }
}
