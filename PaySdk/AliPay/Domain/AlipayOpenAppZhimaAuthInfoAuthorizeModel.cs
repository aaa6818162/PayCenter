using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppZhimaAuthInfoAuthorizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppZhimaAuthInfoAuthorizeModel : AopObject
    {
        /// <summary>
        /// 业务扩展字段，json字符串的key-value格式
        /// </summary>
        [XmlElement("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 不同身份类型的参数列表，json字符串的key-value格式：  如：identityType =0 identityParam ={"openId":"268801234567890123456"}如：identityType =1 identityParam ={"mobileNo":"13588888888"}
        /// </summary>
        [XmlElement("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 身份标识类型（后续可以扩展） 0：芝麻信用开放账号ID 1：按照手机号进行授权 2: 按照身份证+姓名进行授权
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
