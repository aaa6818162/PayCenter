using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasAcquireCustomsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasAcquireCustomsQueryModel : AopObject
    {
        /// <summary>
        /// 需要查询的商户端报关请求号，支持批量查询，多个值用逗号分隔，单次最多10个
        /// </summary>
        [XmlArray("out_request_nos")]
        [XmlArrayItem("string")]
        public List<string> OutRequestNos { get; set; }
    }
}
