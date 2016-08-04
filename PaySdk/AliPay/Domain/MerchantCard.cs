using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCard Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCard : AopObject
    {
        /// <summary>
        /// 支付宝业务卡号
        /// </summary>
        [XmlElement("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 商户卡ID
        /// </summary>
        [XmlElement("external_card_no")]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 会员卡等级，由商户自定义。
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("p_card_balance")]
        public string PCardBalance { get; set; }

        /// <summary>
        /// 会员卡积分。
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
