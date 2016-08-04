using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataBizcontenttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataBizcontenttestModel : AopObject
    {
        /// <summary>
        /// normalparamtest
        /// </summary>
        [XmlElement("normalparamtest")]
        public string Normalparamtest { get; set; }
    }
}
