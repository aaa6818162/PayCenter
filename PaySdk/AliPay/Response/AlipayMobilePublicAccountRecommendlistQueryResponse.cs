using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountRecommendlistQueryResponse.
    /// </summary>
    public class AlipayMobilePublicAccountRecommendlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务窗推荐列表
        /// </summary>
        [XmlArray("app_account_infos")]
        [XmlArrayItem("public_account_info")]
        public List<PublicAccountInfo> AppAccountInfos { get; set; }

        /// <summary>
        /// 200 成功 1001 无效参数
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 失败原因或者成功
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
