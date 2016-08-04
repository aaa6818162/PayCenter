using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasSearchIntendQueryResponse.
    /// </summary>
    public class AlipayMsaasSearchIntendQueryResponse : AopResponse
    {
        /// <summary>
        /// 意图识别结果，格式为SearchResult格式，透传给客户端，客户端当作搜索结果处理
        /// </summary>
        [XmlElement("search_result")]
        public string SearchResult { get; set; }
    }
}
