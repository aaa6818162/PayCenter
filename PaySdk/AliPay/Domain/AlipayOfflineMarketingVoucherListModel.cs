using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherListModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherListModel : AopObject
    {
        /// <summary>
        /// 为了后续兼容，现在只支持CAMP_TOOL
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 券可以发放的开始时间
        /// </summary>
        [XmlElement("gmt_create_from")]
        public string GmtCreateFrom { get; set; }

        /// <summary>
        /// 券可以发放的结束时间
        /// </summary>
        [XmlElement("gmt_create_to")]
        public string GmtCreateTo { get; set; }

        /// <summary>
        /// 分页跳过页的信息
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 每页多少个
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询某种状态的券，现在状态有create和start，默认为start
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
