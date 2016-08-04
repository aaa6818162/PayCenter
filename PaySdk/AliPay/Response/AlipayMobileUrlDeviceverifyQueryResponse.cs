using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileUrlDeviceverifyQueryResponse.
    /// </summary>
    public class AlipayMobileUrlDeviceverifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回本设备是否经过短信认证
        /// </summary>
        [XmlElement("response")]
        public bool Response { get; set; }
    }
}
