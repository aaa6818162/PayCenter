using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Picture Data Structure.
    /// </summary>
    [Serializable]
    public class Picture : AopObject
    {
        /// <summary>
        /// 图片上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
