using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntmemberBenefitBatchqueryResponse.
    /// </summary>
    public class AlipayUserAntmemberBenefitBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁会员权益配置信息列表
        /// </summary>
        [XmlArray("benefit_info_list")]
        [XmlArrayItem("benfit_grade_point")]
        public List<BenfitGradePoint> BenefitInfoList { get; set; }
    }
}
