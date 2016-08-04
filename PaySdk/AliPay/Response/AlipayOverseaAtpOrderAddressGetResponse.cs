using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseaAtpOrderAddressGetResponse.
    /// </summary>
    public class AlipayOverseaAtpOrderAddressGetResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }
    }
}
