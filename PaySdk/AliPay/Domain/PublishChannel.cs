using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublishChannel Data Structure.
    /// </summary>
    [Serializable]
    public class PublishChannel : AopObject
    {
        /// <summary>
        /// 投放配置
        /// </summary>
        [XmlElement("config")]
        public string Config { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
