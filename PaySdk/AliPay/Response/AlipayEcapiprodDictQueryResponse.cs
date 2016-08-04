using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcapiprodDictQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDictQueryResponse : AopResponse
    {
        /// <summary>
        /// 常量具体数据
        /// </summary>
        [XmlElement("categorys")]
        public string Categorys { get; set; }
    }
}
