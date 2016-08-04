using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTransferBankPayApplyResponse.
    /// </summary>
    public class AlipayTransferBankPayApplyResponse : AopResponse
    {
        /// <summary>
        /// 转账申请结果描述
        /// </summary>
        [XmlElement("bank_pay_apply_response")]
        public BankPayApplyResult BankPayApplyResponse { get; set; }
    }
}
