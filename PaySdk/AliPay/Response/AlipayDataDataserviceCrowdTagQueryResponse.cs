using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCrowdTagQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceCrowdTagQueryResponse : AopResponse
    {
        /// <summary>
        /// 创建人群分组
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }
    }
}
