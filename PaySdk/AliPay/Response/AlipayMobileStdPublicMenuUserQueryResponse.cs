using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMenuUserQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicMenuUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜单唯一标识
        /// </summary>
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }
    }
}
