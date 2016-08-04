using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingMobileQrcodeManageResponse.
    /// </summary>
    public class AlipayMarketingMobileQrcodeManageResponse : AopResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 码信息
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 二维码图片地址
        /// </summary>
        [XmlElement("qrcode_img_url")]
        public string QrcodeImgUrl { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回的扩展信息
        /// </summary>
        [XmlElement("return_ext_data")]
        public string ReturnExtData { get; set; }
    }
}
