using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceCrowdDataProfileResponse.
    /// </summary>
    public class AlipayDataDataserviceCrowdDataProfileResponse : AopResponse
    {
        /// <summary>
        /// 人群画像统计结果
        /// </summary>
        [XmlArray("profiles")]
        [XmlArrayItem("string")]
        public List<string> Profiles { get; set; }
    }
}
