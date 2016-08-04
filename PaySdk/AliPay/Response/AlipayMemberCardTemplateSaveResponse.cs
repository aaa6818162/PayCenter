using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMemberCardTemplateSaveResponse.
    /// </summary>
    public class AlipayMemberCardTemplateSaveResponse : AopResponse
    {
        /// <summary>
        /// 支付宝卡模板Id  请求失败时，不存在本参数；  请求成功时，本参数不为空。
        /// </summary>
        [XmlElement("alipay_template_id")]
        public string AlipayTemplateId { get; set; }

        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数返回具体的错误原因。
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 外部商户卡模板id  请求失败时，不存在本参数；  请求成功时，本参数不为空。
        /// </summary>
        [XmlElement("out_template_id")]
        public string OutTemplateId { get; set; }

        /// <summary>
        /// 请求是否成功。  T代表成功  F代表失败
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
