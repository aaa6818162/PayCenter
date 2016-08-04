using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAlisisSpeedupQueryResponse.
    /// </summary>
    public class AlipayDataAlisisSpeedupQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回加速状态
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
