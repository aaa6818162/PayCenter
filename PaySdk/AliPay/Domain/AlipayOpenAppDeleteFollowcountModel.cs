using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppDeleteFollowcountModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeleteFollowcountModel : AopObject
    {
        /// <summary>
        /// share
        /// </summary>
        [XmlElement("share")]
        public string Share { get; set; }
    }
}
