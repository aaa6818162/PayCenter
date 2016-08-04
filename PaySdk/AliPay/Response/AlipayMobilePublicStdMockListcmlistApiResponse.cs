using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicStdMockListcmlistApiResponse.
    /// </summary>
    public class AlipayMobilePublicStdMockListcmlistApiResponse : AopResponse
    {
        /// <summary>
        /// 复杂对象嵌套list
        /// </summary>
        [XmlArray("list_cm_list")]
        [XmlArrayItem("list_list_complex_mock_model")]
        public List<ListListComplexMockModel> ListCmList { get; set; }
    }
}
