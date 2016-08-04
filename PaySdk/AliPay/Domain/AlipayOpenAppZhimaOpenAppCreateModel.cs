using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppZhimaOpenAppCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppZhimaOpenAppCreateModel : AopObject
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }
    }
}
