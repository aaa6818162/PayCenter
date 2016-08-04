using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceXwbtestResponse.
    /// </summary>
    public class AlipayCreditAutofinanceXwbtestResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("xwb")]
        public string Xwb { get; set; }
    }
}
