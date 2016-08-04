using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicMockListcomplexmodelApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockListcomplexmodelApiResponse : AopResponse
    {
        /// <summary>
        /// 208x
        /// </summary>
        [XmlArray("cm_model_list")]
        [XmlArrayItem("old_complext_mock_model")]
        public List<OldComplextMockModel> CmModelList { get; set; }
    }
}
