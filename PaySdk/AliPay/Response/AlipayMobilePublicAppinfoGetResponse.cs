using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicAppinfoGetResponse.
    /// </summary>
    public class AlipayMobilePublicAppinfoGetResponse : AopResponse
    {
        /// <summary>
        /// 结果编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 服务窗基本信息
        /// </summary>
        [XmlElement("service_window_info")]
        public AppInfoSetting ServiceWindowInfo { get; set; }
    }
}
