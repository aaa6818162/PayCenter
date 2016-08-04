using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRechargeOrderUpdateResponse.
    /// </summary>
    public class AlipayEbppRechargeOrderUpdateResponse : AopResponse
    {
        /// <summary>
        /// 详细的业务处理异常code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
