using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMobilessoTokenGetResponse.
    /// </summary>
    public class AlipayUserMobilessoTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 授权用户获得的token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }

        /// <summary>
        /// 授权用户的id。  支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
