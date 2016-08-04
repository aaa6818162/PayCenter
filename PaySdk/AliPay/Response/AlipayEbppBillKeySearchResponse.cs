using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillKeySearchResponse.
    /// </summary>
    public class AlipayEbppBillKeySearchResponse : AopResponse
    {
        /// <summary>
        /// 请求受理ID。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
