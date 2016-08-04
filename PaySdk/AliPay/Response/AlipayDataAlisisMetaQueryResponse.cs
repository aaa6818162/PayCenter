using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAlisisMetaQueryResponse.
    /// </summary>
    public class AlipayDataAlisisMetaQueryResponse : AopResponse
    {
        /// <summary>
        /// 报表meta信息
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
