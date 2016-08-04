using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditAutofinanceXwbtestModel Data Structure.
    /// </summary>
    [Serializable]
    public class CreditAutofinanceXwbtestModel : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlArray("xwbte")]
        [XmlArrayItem("string")]
        public List<string> Xwbte { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwbtest")]
        public string Xwbtest { get; set; }
    }
}
