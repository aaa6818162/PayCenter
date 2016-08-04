using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileLoginUnifyalipayLoginResponse.
    /// </summary>
    public class AlipayMobileLoginUnifyalipayLoginResponse : AopResponse
    {
        /// <summary>
        /// 支付宝登录id
        /// </summary>
        [XmlElement("alipay_login_id")]
        public string AlipayLoginId { get; set; }

        /// <summary>
        /// 返回状态码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展参数(json格式)
        /// </summary>
        [XmlElement("extern_params")]
        public string ExternParams { get; set; }

        /// <summary>
        /// Havanaid
        /// </summary>
        [XmlElement("hid")]
        public string Hid { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 是否通过了支付宝安全校验
        /// </summary>
        [XmlElement("pass_alipay_security")]
        public string PassAlipaySecurity { get; set; }

        /// <summary>
        /// 是否成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 是否手机域账户
        /// </summary>
        [XmlElement("wireless")]
        public bool Wireless { get; set; }
    }
}
