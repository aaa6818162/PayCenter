using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountIsrecommendGetResponse.
    /// </summary>
    public class AlipayMobilePublicAccountIsrecommendGetResponse : AopResponse
    {
        /// <summary>
        /// 200 成功 1001 无效参数
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 是否需要公众号推荐
        /// </summary>
        [XmlElement("is_need_recommand")]
        public bool IsNeedRecommand { get; set; }

        /// <summary>
        /// 失败原因或者成功
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
