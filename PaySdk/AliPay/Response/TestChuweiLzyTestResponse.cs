using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TestChuweiLzyTestResponse.
    /// </summary>
    public class TestChuweiLzyTestResponse : AopResponse
    {
        /// <summary>
        /// dfdf
        /// </summary>
        [XmlElement("dfdf")]
        public AlipassOpenAPIRequest Dfdf { get; set; }
    }
}
