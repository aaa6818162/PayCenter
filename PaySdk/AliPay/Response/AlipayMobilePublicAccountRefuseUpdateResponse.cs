using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountRefuseUpdateResponse.
    /// </summary>
    public class AlipayMobilePublicAccountRefuseUpdateResponse : AopResponse
    {
        /// <summary>
        /// code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 是否拒绝推荐成功
        /// </summary>
        [XmlElement("is_sucess_refuse")]
        public string IsSucessRefuse { get; set; }

        /// <summary>
        /// msg
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
