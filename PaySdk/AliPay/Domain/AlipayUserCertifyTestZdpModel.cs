using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyTestZdpModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyTestZdpModel : AopObject
    {
        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("_test")]
        public string Test { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 333
        /// </summary>
        [XmlElement("kmttt")]
        public string Kmttt { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("sdfasdfsadfdsafs")]
        public string Sdfasdfsadfdsafs { get; set; }
    }
}
