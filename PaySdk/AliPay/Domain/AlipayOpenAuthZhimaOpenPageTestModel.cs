using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthZhimaOpenPageTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthZhimaOpenPageTestModel : AopObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlArray("name")]
        [XmlArrayItem("string")]
        public List<string> Name { get; set; }
    }
}
