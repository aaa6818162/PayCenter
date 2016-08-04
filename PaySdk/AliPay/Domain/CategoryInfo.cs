using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryInfo : AopObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 父类目编码
        /// </summary>
        [XmlElement("parent_category_code")]
        public string ParentCategoryCode { get; set; }
    }
}
