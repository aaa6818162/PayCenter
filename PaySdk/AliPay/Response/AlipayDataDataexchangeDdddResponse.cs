using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeDdddResponse.
    /// </summary>
    public class AlipayDataDataexchangeDdddResponse : AopResponse
    {
        /// <summary>
        /// dsfsdg
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
