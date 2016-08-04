using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAlisisOlapQueryResponse.
    /// </summary>
    public class AlipayDataAlisisOlapQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果返回值
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
