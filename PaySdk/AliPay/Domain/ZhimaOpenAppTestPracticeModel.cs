using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppTestPracticeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppTestPracticeModel : AopObject
    {
        /// <summary>
        /// a d
        /// </summary>
        [XmlArray("add")]
        [XmlArrayItem("string")]
        public List<string> Add { get; set; }

        /// <summary>
        /// ad
        /// </summary>
        [XmlElement("dddd")]
        public string Dddd { get; set; }

        /// <summary>
        /// ddd
        /// </summary>
        [XmlElement("fff")]
        public string Fff { get; set; }

        /// <summary>
        /// cc
        /// </summary>
        [XmlElement("ggg")]
        public string Ggg { get; set; }

        /// <summary>
        /// zzz
        /// </summary>
        [XmlElement("xxxx")]
        public XXXXsdasdasd Xxxx { get; set; }
    }
}
