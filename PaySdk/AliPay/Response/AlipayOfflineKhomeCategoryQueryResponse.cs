using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineKhomeCategoryQueryResponse.
    /// </summary>
    public class AlipayOfflineKhomeCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑到家类目列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("category_info")]
        public List<CategoryInfo> CategoryList { get; set; }
    }
}
