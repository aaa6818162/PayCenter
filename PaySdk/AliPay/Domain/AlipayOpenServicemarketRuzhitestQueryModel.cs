using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketRuzhitestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketRuzhitestQueryModel : AopObject
    {
        /// <summary>
        /// app在开发平台的name
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 入参数据结构描述（RuzhiTest）
        /// </summary>
        [XmlElement("peoples")]
        public RuzhiTest Peoples { get; set; }
    }
}
