using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceReportQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的报表数据，json格式
        /// </summary>
        [XmlElement("report_data")]
        public string ReportData { get; set; }
    }
}
