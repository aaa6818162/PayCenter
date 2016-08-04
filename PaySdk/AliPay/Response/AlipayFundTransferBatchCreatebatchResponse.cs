using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransferBatchCreatebatchResponse.
    /// </summary>
    public class AlipayFundTransferBatchCreatebatchResponse : AopResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
