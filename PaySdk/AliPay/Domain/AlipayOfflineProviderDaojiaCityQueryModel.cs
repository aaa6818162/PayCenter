using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderDaojiaCityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderDaojiaCityQueryModel : AopObject
    {
        /// <summary>
        /// 需要请求的当前页，1表示第一页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页记录条数，默认为50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
