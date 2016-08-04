using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolMobileQrcodeManageModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolMobileQrcodeManageModel : AopObject
    {
        /// <summary>
        /// 业务数据,详情见接入文档的biz_data项
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 商品码
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 添加二维码／修改二维码／停用二维码／重启启用二维码,根据场景选择其中一种
        /// </summary>
        [XmlElement("method")]
        public string Method { get; set; }

        /// <summary>
        /// 码值
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }
    }
}
