using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcapiprodFileUploadResponse.
    /// </summary>
    public class AlipayEcapiprodFileUploadResponse : AopResponse
    {
        /// <summary>
        /// oss bucket name
        /// </summary>
        [XmlElement("oss_bucket")]
        public string OssBucket { get; set; }

        /// <summary>
        /// oss path
        /// </summary>
        [XmlElement("oss_path")]
        public string OssPath { get; set; }
    }
}
