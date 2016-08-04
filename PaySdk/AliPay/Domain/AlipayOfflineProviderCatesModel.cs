using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCatesModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCatesModel : AopObject
    {
        /// <summary>
        /// 查询口碑到家类目编码列表的当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 查询口碑到家类目编码的每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
