using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppZhimaCreditShareriskGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppZhimaCreditShareriskGetModel : AopObject
    {
        /// <summary>
        /// 业务申请单号
        /// </summary>
        [XmlElement("biz_apply_no")]
        public string BizApplyNo { get; set; }

        /// <summary>
        /// 授权合同编号
        /// </summary>
        [XmlElement("biz_auth_no")]
        public string BizAuthNo { get; set; }

        /// <summary>
        /// 业务场景[01： 申贷审批； 02： 贷后管理]
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型[100：身份证]
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户传入的业务流水号。此字段由商户生成，需确保唯一性，用于定位每一次请求，后续按此流水进行对帐。生成规则: 固定30位数字串，前17位为精确到毫秒的时间yyyyMMddhhmmssSSS，后13位为自增数字。
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
