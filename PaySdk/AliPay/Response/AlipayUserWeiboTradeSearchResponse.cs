using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserWeiboTradeSearchResponse.
    /// </summary>
    public class AlipayUserWeiboTradeSearchResponse : AopResponse
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 微博交易记录列表
        /// </summary>
        [XmlArray("weibo_trade_records")]
        [XmlArrayItem("weibo_trade_record")]
        public List<WeiboTradeRecord> WeiboTradeRecords { get; set; }
    }
}
