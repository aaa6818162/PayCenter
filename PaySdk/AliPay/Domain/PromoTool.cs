using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoTool Data Structure.
    /// </summary>
    [Serializable]
    public class PromoTool : AopObject
    {
        /// <summary>
        /// 奖品发放的规则
        /// </summary>
        [XmlElement("send_rule")]
        public SendRule SendRule { get; set; }

        /// <summary>
        /// 券对象(仅当is_create为0时有效)
        /// </summary>
        [XmlElement("voucher")]
        public Voucher Voucher { get; set; }

        /// <summary>
        /// 营销工具uid
        /// </summary>
        [XmlElement("voucher_no")]
        public string VoucherNo { get; set; }
    }
}
