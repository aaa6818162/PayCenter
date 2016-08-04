using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMockListsimplemodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockListsimplemodelApiResponse : AopResponse
    {
        /// <summary>
        /// 2088
        /// </summary>
        [XmlArray("biz_model_list")]
        [XmlArrayItem("simple_mock_model")]
        public List<SimpleMockModel> BizModelList { get; set; }
    }
}
