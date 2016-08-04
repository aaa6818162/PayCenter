using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliCreditScoreResult Data Structure.
    /// </summary>
    [Serializable]
    public class AliCreditScoreResult : AopObject
    {
        /// <summary>
        /// 信用支付额度是否大于等于50
        /// </summary>
        [XmlElement("is_credit_pay_enabled")]
        public bool IsCreditPayEnabled { get; set; }
    }
}
