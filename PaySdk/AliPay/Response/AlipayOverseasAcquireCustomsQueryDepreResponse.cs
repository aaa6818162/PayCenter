using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasAcquireCustomsQueryDepreResponse.
    /// </summary>
    public class AlipayOverseasAcquireCustomsQueryDepreResponse : AopResponse
    {
        /// <summary>
        /// 未找到记录的报关单列表
        /// </summary>
        [XmlArray("not_found")]
        [XmlArrayItem("string")]
        public List<string> NotFound { get; set; }

        /// <summary>
        /// 匹配到的报关单列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("declare_record")]
        public List<DeclareRecord> Records { get; set; }
    }
}
