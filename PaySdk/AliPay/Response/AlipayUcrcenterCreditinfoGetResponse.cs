using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUcrcenterCreditinfoGetResponse.
    /// </summary>
    public class AlipayUcrcenterCreditinfoGetResponse : AopResponse
    {
        /// <summary>
        /// 阿里集团内部查询的信用信息
        /// </summary>
        [XmlElement("ali_credit_info_result")]
        public AliCreditInfoResultForAliGroup AliCreditInfoResult { get; set; }
    }
}
