using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppInfoSetting Data Structure.
    /// </summary>
    [Serializable]
    public class AppInfoSetting : AopObject
    {
        /// <summary>
        /// 介绍
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 该公众账号是否能绑定外部户的标识
        /// </summary>
        [XmlElement("can_add_third_account")]
        public string CanAddThirdAccount { get; set; }

        /// <summary>
        /// 可以绑定外部户时，页面显示的文案
        /// </summary>
        [XmlElement("display_third_account_text")]
        public string DisplayThirdAccountText { get; set; }

        /// <summary>
        /// 关注欢迎语
        /// </summary>
        [XmlElement("greeting")]
        public string Greeting { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 公众号页面顶部分割线颜色
        /// </summary>
        [XmlElement("public_divider_color")]
        public string PublicDividerColor { get; set; }

        /// <summary>
        /// 服务区域
        /// </summary>
        [XmlElement("service_area")]
        public string ServiceArea { get; set; }
    }
}
