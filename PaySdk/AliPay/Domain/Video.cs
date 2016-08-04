using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Video Data Structure.
    /// </summary>
    [Serializable]
    public class Video : AopObject
    {
        /// <summary>
        /// 图片上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
