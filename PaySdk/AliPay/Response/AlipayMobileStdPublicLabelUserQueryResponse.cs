using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicLabelUserQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicLabelUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 标签编号，英文逗号分隔
        /// </summary>
        [XmlElement("label_ids")]
        public string LabelIds { get; set; }
    }
}
