using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcardEduLimitAmountQueryResponse.
    /// </summary>
    public class AlipayEcardEduLimitAmountQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校code
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 受限金额
        /// </summary>
        [XmlElement("limit_amount")]
        public string LimitAmount { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
