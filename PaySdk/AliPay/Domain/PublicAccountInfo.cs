using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PublicAccountInfo : AopObject
    {
        /// <summary>
        /// 描述跳转URl
        /// </summary>
        [XmlElement("desc_url")]
        public string DescUrl { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 服务窗描述
        /// </summary>
        [XmlElement("public_desc")]
        public string PublicDesc { get; set; }

        /// <summary>
        /// 服务窗ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 服务窗账号名称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }
    }
}
