using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceMonitorCouponQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceMonitorCouponQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回动态的央视需要的数据，对应传入的业务标识(biz_id)来进行区别
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
