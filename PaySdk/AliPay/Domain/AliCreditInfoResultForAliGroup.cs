using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliCreditInfoResultForAliGroup Data Structure.
    /// </summary>
    [Serializable]
    public class AliCreditInfoResultForAliGroup : AopObject
    {
        /// <summary>
        /// 信用等级
        /// </summary>
        [XmlElement("credit_group")]
        public string CreditGroup { get; set; }

        /// <summary>
        /// 信用分
        /// </summary>
        [XmlElement("credit_score")]
        public long CreditScore { get; set; }

        /// <summary>
        /// 是否实名认证
        /// </summary>
        [XmlElement("is_certify")]
        public long IsCertify { get; set; }
    }
}
