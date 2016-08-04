using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicLabelQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 所有标签
        /// </summary>
        [XmlArray("label_list")]
        [XmlArrayItem("public_label")]
        public List<PublicLabel> LabelList { get; set; }
    }
}
