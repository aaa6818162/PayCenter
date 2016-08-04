using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPwdTrasferAccountResponse.
    /// </summary>
    public class AlipayUserPwdTrasferAccountResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("accorder")]
        public string Accorder { get; set; }
    }
}
