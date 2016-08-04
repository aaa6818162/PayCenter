using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArticlePicture Data Structure.
    /// </summary>
    [Serializable]
    public class ArticlePicture : AopObject
    {
        /// <summary>
        /// 图片的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片上传到素材中心后，生成的ID
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片的类型，定义如下：  菜品:DISH ，环境:ENVIRONMENT ，门头照:SHOPHEAD ，其他:OTHER
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
