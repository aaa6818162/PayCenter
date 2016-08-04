using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppAlipayOpenZhimaZhimaTestResponse.
    /// </summary>
    public class ZhimaOpenAppAlipayOpenZhimaZhimaTestResponse : AopResponse
    {
        /// <summary>
        /// type_id
        /// </summary>
        [XmlElement("type_id")]
        public string TypeId { get; set; }
    }
}
