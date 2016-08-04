using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAlisisSpeedupEnableResponse.
    /// </summary>
    public class AlipayDataAlisisSpeedupEnableResponse : AopResponse
    {
        /// <summary>
        /// 加速是否成功
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
