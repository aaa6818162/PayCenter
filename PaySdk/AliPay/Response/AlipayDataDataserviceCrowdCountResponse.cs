using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCrowdCountResponse.
    /// </summary>
    public class AlipayDataDataserviceCrowdCountResponse : AopResponse
    {
        /// <summary>
        /// 返回一组规则的人群数量
        /// </summary>
        [XmlArray("crowd_count")]
        [XmlArrayItem("number")]
        public List<long> CrowdCount { get; set; }
    }
}
