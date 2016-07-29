using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketShopModifyResponse : AopResponse
    {
        /// <summary>
        /// ISV每次请求都会在支付宝保存一条流水，apply_id为流水Id,此字段留作后续功能扩展使用。  2.0接口同步修改门店将返回流水id。可以通过接口：alipay.offline.market.applyorder.batchquery查询流水的审核状态。
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 门店审核状态描述，如果审核驳回则有相关的驳回理由。  2.0接口同步返回将不再有此字段，审核结果将在审核通知中给出。
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 门店审核状态，对于系统商而言，只有三个状态，AUDITING：审核中，AUDIT_FAILED：审核驳回，AUDIT_SUCCESS：审核通过。第一次审核通过会触发门店上架。  2.0接口，同步请求如果支付宝受理成功，将返回AUDITING状态。
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 门店是否上架，T表示上架,F表示未上架，第一次门店审核通过后会触发上架。  2.0接口同步返回中将不再有此字段，门店是否上架将通过异步审核通知到ISV，或者ISV通过流水查询接口获取门店审核流水的状态。
        /// </summary>
        [XmlElement("is_online")]
        public string IsOnline { get; set; }

        /// <summary>
        /// 门店是否在客户端显示，T表示显示，F表示隐藏。  2.0接口同步返回中将不再有此字段，门店展示状态将通过异步审核通知到ISV。
        /// </summary>
        [XmlElement("is_show")]
        public string IsShow { get; set; }
    }
}
