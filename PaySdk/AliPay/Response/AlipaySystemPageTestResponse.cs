using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySystemPageTestResponse.
    /// </summary>
    public class AlipaySystemPageTestResponse : AopResponse
    {
        /// <summary>
        /// tes
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
