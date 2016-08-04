using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransferBatchQuerybatchResponse.
    /// </summary>
    public class AlipayFundTransferBatchQuerybatchResponse : AopResponse
    {
        /// <summary>
        /// 收款理由
        /// </summary>
        [XmlElement("batch_memo")]
        public string BatchMemo { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("batch_type")]
        public string BatchType { get; set; }

        /// <summary>
        /// 批次创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 批次创建者ID（支付宝Id）
        /// </summary>
        [XmlElement("create_user_id")]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 收付款明细的list
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("query_detail_aop_result")]
        public List<QueryDetailAopResult> DetailList { get; set; }

        /// <summary>
        /// 扩展参数，map的json串格式
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 单笔金额
        /// </summary>
        [XmlElement("pay_amount_single")]
        public string PayAmountSingle { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("pay_amount_total")]
        public string PayAmountTotal { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("real_items_total")]
        public string RealItemsTotal { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("show_items_total")]
        public string ShowItemsTotal { get; set; }

        /// <summary>
        /// 已付总金额
        /// </summary>
        [XmlElement("success_amount_total")]
        public string SuccessAmountTotal { get; set; }

        /// <summary>
        /// 已付总笔数
        /// </summary>
        [XmlElement("success_items_total")]
        public string SuccessItemsTotal { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("time_out_value")]
        public string TimeOutValue { get; set; }

        /// <summary>
        /// 用于防止遍历批次的token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
