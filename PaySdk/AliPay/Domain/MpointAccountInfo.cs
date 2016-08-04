using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpointAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MpointAccountInfo : AopObject
    {
        /// <summary>
        /// 该笔交易后该账户积分余额
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 业务流水号：积分核心指令流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 积分发放业务描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 该笔交易金额
        /// </summary>
        [XmlElement("trans_amount")]
        public long TransAmount { get; set; }

        /// <summary>
        /// 积分业务交易时间
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }
    }
}
