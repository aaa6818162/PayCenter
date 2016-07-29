using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DisplayConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DisplayConfig : AopObject
    {
        /// <summary>
        /// 券的宣传语
        /// </summary>
        [XmlElement("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 券的宣传图片
        /// </summary>
        [XmlElement("slogan_img")]
        public string SloganImg { get; set; }
    }
}
