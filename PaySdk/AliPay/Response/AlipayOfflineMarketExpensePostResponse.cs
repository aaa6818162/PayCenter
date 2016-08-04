using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketExpensePostResponse.
    /// </summary>
    public class AlipayOfflineMarketExpensePostResponse : AopResponse
    {
        /// <summary>
        /// 操作返回结果，JSON格式
        /// </summary>
        [XmlElement("response")]
        public string Response { get; set; }
    }
}
