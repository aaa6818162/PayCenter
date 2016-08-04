using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserScoreGfGetResponse.
    /// </summary>
    public class AlipayTrustUserScoreGfGetResponse : AopResponse
    {
        /// <summary>
        /// 结果集合
        /// </summary>
        [XmlArray("gf_list")]
        [XmlArrayItem("gf_result")]
        public List<GfResult> GfList { get; set; }
    }
}
