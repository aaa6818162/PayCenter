using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppSearchFollowcountModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSearchFollowcountModel : AopObject
    {
        /// <summary>
        /// 请求
        /// </summary>
        [XmlElement("requet")]
        public string Requet { get; set; }
    }
}
