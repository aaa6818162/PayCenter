using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsuranceAccountQueryResponse.
    /// </summary>
    public class AlipayInsuranceAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 保险服务结束时间
        /// </summary>
        [XmlElement("effect_end_date")]
        public string EffectEndDate { get; set; }

        /// <summary>
        /// 保险服务开始时间
        /// </summary>
        [XmlElement("effect_start_date")]
        public string EffectStartDate { get; set; }

        /// <summary>
        /// 用户是否已投保
        /// </summary>
        [XmlElement("insured")]
        public bool Insured { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
