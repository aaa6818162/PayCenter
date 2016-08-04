using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicStdMockListcomplexmodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicStdMockListcomplexmodelApiResponse : AopResponse
    {
        /// <summary>
        /// 2xxx
        /// </summary>
        [XmlArray("cm_model_list")]
        [XmlArrayItem("complext_mock_model")]
        public List<ComplextMockModel> CmModelList { get; set; }
    }
}
