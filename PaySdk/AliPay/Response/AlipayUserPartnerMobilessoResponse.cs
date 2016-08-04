using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPartnerMobilessoResponse.
    /// </summary>
    public class AlipayUserPartnerMobilessoResponse : AopResponse
    {
        /// <summary>
        /// 2088102114230015
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
