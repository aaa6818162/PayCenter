using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDatabizCoreUserEvaluationGetResponse.
    /// </summary>
    public class AlipayDatabizCoreUserEvaluationGetResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户标识
        /// </summary>
        [XmlElement("alipay_user_flag")]
        public string AlipayUserFlag { get; set; }

        /// <summary>
        /// 支付宝钱包用户标识
        /// </summary>
        [XmlElement("mob_client_user_flag")]
        public string MobClientUserFlag { get; set; }

        /// <summary>
        /// 无线支付能力等级
        /// </summary>
        [XmlElement("mob_pay_ability_level")]
        public string MobPayAbilityLevel { get; set; }

        /// <summary>
        /// 返回的流水号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 数娱行业活跃用户标识
        /// </summary>
        [XmlElement("trd_sy_user_flag")]
        public string TrdSyUserFlag { get; set; }

        /// <summary>
        /// 消费品位
        /// </summary>
        [XmlElement("user_consume_label")]
        public string UserConsumeLabel { get; set; }

        /// <summary>
        /// 消费水平等级
        /// </summary>
        [XmlElement("user_consume_level")]
        public string UserConsumeLevel { get; set; }

        /// <summary>
        /// 支付能力等级
        /// </summary>
        [XmlElement("user_pay_level")]
        public string UserPayLevel { get; set; }
    }
}
