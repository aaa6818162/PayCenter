using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataIndicatorQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataIndicatorQueryResponse : AopResponse
    {
        /// <summary>
        /// JSON格式数组，每个对象表示一个门店某个具体日期的指标信息，KEY为指标代码，VALUE为该指标对应的值
        /// </summary>
        [XmlElement("indicator_infos")]
        public string IndicatorInfos { get; set; }

        /// <summary>
        /// 总条目数,供计算分页信息使用
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
