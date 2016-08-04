using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicInfoQueryModel : AopObject
    {
        /// <summary>
        /// 服务窗ID
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }
    }
}
