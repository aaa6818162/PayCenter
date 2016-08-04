using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMpointprodDispatchOrderQueryResponse.
    /// </summary>
    public class AlipayUserMpointprodDispatchOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 会员积分交易账户详情对象
        /// </summary>
        [XmlElement("account_info")]
        public MpointAccountInfo AccountInfo { get; set; }
    }
}
