using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipassOpenAPIRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AlipassOpenAPIRequest : AopObject
    {
        /// <summary>
        /// 开放平台为商户分配的ID
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// alipass文件Base64编码后的内容。
        /// </summary>
        [XmlElement("file_content")]
        public string FileContent { get; set; }

        /// <summary>
        /// 商户外部交易号，由商户生成并确保其唯一性
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
