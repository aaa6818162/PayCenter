using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBaitiaoprodAccountQueryResponse.
    /// </summary>
    public class AlipayBaitiaoprodAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 本次接口调用的错误信息描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 当前账号是否已签约
        /// </summary>
        [XmlElement("has_sign")]
        public bool HasSign { get; set; }

        /// <summary>
        /// 当前账号在余额宝分期付是否有未完结的订单
        /// </summary>
        [XmlElement("has_unfinished_order")]
        public bool HasUnfinishedOrder { get; set; }

        /// <summary>
        /// 当前账号是否在余额宝分期付服务中
        /// </summary>
        [XmlElement("in_service")]
        public bool InService { get; set; }

        /// <summary>
        /// 本次接口调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
