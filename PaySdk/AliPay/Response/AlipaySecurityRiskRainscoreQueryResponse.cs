using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskRainscoreQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskRainscoreQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险解释，即本次风险评分中TOP 3风险因子的代码、名称、解释、风险倍数（JSON格式）。详情请参考<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=139&articleId=104588&docType=1">风险解释</a>
        /// </summary>
        [XmlArray("infocode")]
        [XmlArrayItem("info_code")]
        public List<InfoCode> Infocode { get; set; }

        /// <summary>
        /// 风险评分，范围为[0,100]，评分越高风险越大
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
