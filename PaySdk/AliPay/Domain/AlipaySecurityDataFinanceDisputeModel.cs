using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataFinanceDisputeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataFinanceDisputeModel : AopObject
    {
        /// <summary>
        /// 银行机构代码
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 充值订单号
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }
    }
}
