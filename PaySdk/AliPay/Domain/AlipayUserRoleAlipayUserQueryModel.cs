using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserRoleAlipayUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserRoleAlipayUserQueryModel : AopObject
    {
        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("req_time")]
        public string ReqTime { get; set; }
    }
}
