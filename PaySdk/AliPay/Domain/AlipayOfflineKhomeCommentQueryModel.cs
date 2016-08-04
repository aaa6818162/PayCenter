using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineKhomeCommentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineKhomeCommentQueryModel : AopObject
    {
        /// <summary>
        /// 口碑到家订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
