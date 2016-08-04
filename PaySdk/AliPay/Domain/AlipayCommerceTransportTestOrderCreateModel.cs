using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTestOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTestOrderCreateModel : AopObject
    {
        /// <summary>
        /// 呵呵又呵呵
        /// </summary>
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 复杂类型测试
        /// </summary>
        [XmlElement("mock")]
        public EcoMock Mock { get; set; }
    }
}
