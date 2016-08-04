using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasInremitRemittanceValidateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasInremitRemittanceValidateModel : AopObject
    {
        /// <summary>
        /// partnerId
        /// </summary>
        [XmlElement("partner")]
        public string Partner { get; set; }

        /// <summary>
        /// 接受方期望接受到的钱数值，两位小数
        /// </summary>
        [XmlElement("receiving_amount")]
        public string ReceivingAmount { get; set; }

        /// <summary>
        /// 接受币种
        /// </summary>
        [XmlElement("receiving_amount_currency")]
        public string ReceivingAmountCurrency { get; set; }

        /// <summary>
        /// 接受人，包括名，姓和账号的logonId
        /// </summary>
        [XmlElement("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// 表明验证模式，可以是全名，不需要验证，或者姓验证
        /// </summary>
        [XmlElement("validate_type")]
        public string ValidateType { get; set; }
    }
}
