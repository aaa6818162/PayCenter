using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasInremitRemittanceValidateResponse.
    /// </summary>
    public class AlipayOverseasInremitRemittanceValidateResponse : AopResponse
    {
        /// <summary>
        /// 验证是否成功
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }
    }
}
