using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillSearchTeachResponse.
    /// </summary>
    public class AlipayEbppBillSearchTeachResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("cachekey")]
        public string Cachekey { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("inst_bill_info_list")]
        [XmlArrayItem("query_inst_bill_info")]
        public List<QueryInstBillInfo> InstBillInfoList { get; set; }
    }
}
