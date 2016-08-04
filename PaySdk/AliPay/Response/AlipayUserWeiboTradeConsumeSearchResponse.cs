using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserWeiboTradeConsumeSearchResponse.
    /// </summary>
    public class AlipayUserWeiboTradeConsumeSearchResponse : AopResponse
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public string TotalResults { get; set; }

        /// <summary>
        /// 微博交易记录列表
        /// </summary>
        [XmlElement("weibo_trade_records")]
        public WeiboTradeRecord WeiboTradeRecords { get; set; }
    }
}
