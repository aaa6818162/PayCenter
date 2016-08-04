using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetVoucherVoucherDirectuseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetVoucherVoucherDirectuseModel : AopObject
    {
        /// <summary>
        /// 业务发生时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 0156468653835689006788030091
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。  用户的支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 待核销券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
