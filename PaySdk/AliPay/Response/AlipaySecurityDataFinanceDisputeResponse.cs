using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataFinanceDisputeResponse.
    /// </summary>
    public class AlipaySecurityDataFinanceDisputeResponse : AopResponse
    {
        /// <summary>
        /// 充值账户登陆邮箱/手机
        /// </summary>
        [XmlElement("buyer_login_account")]
        public string BuyerLoginAccount { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
