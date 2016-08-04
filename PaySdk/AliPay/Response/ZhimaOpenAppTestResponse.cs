using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppTestResponse.
    /// </summary>
    public class ZhimaOpenAppTestResponse : AopResponse
    {
        /// <summary>
        /// 执行是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
