using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyTestZdpoResponse.
    /// </summary>
    public class AlipayUserCertifyTestZdpoResponse : AopResponse
    {
        /// <summary>
        /// 99
        /// </summary>
        [XmlElement("hkhikuuuu")]
        public string Hkhikuuuu { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
