using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeclareRecord Data Structure.
    /// </summary>
    [Serializable]
    public class DeclareRecord : AopObject
    {
        /// <summary>
        /// 支付宝推送到海关的支付单据号
        /// </summary>
        [XmlElement("alipay_declare_no")]
        public string AlipayDeclareNo { get; set; }

        /// <summary>
        /// 商户端报关请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
