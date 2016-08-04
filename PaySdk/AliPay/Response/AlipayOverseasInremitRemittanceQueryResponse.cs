using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasInremitRemittanceQueryResponse.
    /// </summary>
    public class AlipayOverseasInremitRemittanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 汇款单的接受时间
        /// </summary>
        [XmlElement("accept_time")]
        public string AcceptTime { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trans_id")]
        public string AlipayTransId { get; set; }

        /// <summary>
        /// 银行从汇款机构的NRA账号扣钱的交易号
        /// </summary>
        [XmlElement("bank_trans_id")]
        public string BankTransId { get; set; }

        /// <summary>
        /// 银行实际使用的汇率
        /// </summary>
        [XmlElement("deduct_fx_rate")]
        public string DeductFxRate { get; set; }

        /// <summary>
        /// 表示api调用失败的原因
        /// </summary>
        [XmlElement("error")]
        public string Error { get; set; }

        /// <summary>
        /// 表示这个api的调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 外部商户的交易号码
        /// </summary>
        [XmlElement("partner_trans_id")]
        public string PartnerTransId { get; set; }

        /// <summary>
        /// 实际接收方收到的钱的数目
        /// </summary>
        [XmlElement("receiving_amount")]
        public string ReceivingAmount { get; set; }

        /// <summary>
        /// 接收方实际收到金额对应的币种
        /// </summary>
        [XmlElement("receiving_amount_currency")]
        public string ReceivingAmountCurrency { get; set; }

        /// <summary>
        /// 汇款成功的时间戳，北京时间
        /// </summary>
        [XmlElement("result_time")]
        public string ResultTime { get; set; }

        /// <summary>
        /// 实际上从汇款机构在银行开的NRA账号里面扣除的数额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 银行从NRA账号扣除金额对应的币种
        /// </summary>
        [XmlElement("settle_amount_currency")]
        public string SettleAmountCurrency { get; set; }

        /// <summary>
        /// 汇款单当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 错误状态的原因
        /// </summary>
        [XmlElement("status_error")]
        public string StatusError { get; set; }
    }
}
