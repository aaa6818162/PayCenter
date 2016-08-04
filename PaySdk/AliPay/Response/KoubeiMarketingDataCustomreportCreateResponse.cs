using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportCreateResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportCreateResponse : AopResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
