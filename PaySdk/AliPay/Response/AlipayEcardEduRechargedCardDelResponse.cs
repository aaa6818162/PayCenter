using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcardEduRechargedCardDelResponse.
    /// </summary>
    public class AlipayEcardEduRechargedCardDelResponse : AopResponse
    {
        /// <summary>
        /// 机构编号
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 删除成功
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }
    }
}
