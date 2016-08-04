using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileSecuritiesInfoUpdateResponse.
    /// </summary>
    public class AlipayMobileSecuritiesInfoUpdateResponse : AopResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
