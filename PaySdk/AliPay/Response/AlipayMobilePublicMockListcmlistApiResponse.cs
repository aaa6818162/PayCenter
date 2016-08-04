using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMockListcmlistApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockListcmlistApiResponse : AopResponse
    {
        /// <summary>
        /// 复杂对象嵌套list
        /// </summary>
        [XmlArray("list_cm_list")]
        [XmlArrayItem("old_list_list_complex_mock_model")]
        public List<OldListListComplexMockModel> ListCmList { get; set; }
    }
}
