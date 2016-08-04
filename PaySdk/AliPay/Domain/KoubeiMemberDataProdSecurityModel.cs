using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMemberDataProdSecurityModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataProdSecurityModel : AopObject
    {
        /// <summary>
        /// asdas
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
