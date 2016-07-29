using System;
using Newtonsoft.Json;
using SyncSoft.PayCenterSdk.Config;
using SyncSoft.PayCenterSdk.Model;
using SyncSoft.PayCenterSdk.Response;

namespace SyncSoft.PayCenterSdk.Request
{
    public class PayCenterRequest
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string Partner { get; set; }

        public string PartnerToken { get; set; }


        /// <summary>
        /// 商户号 对应的支付信息
        /// </summary>
        public PartnerConfig PartnerConfig { get; set; }

        /// <summary>
        /// 第三方支付返回信息
        /// </summary>
        public ThirdPayResponse ThirdPayResponse { get; set; }

        /// <summary>
        /// 登录账号名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 登录账号Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付方式 
        /// </summary>
        public PayEnum PayType { get; set; }

        /// <summary>
        /// 支付备注信息
        /// </summary>
        public string PayRemark { get; set; }

        /// <summary>
        /// 订单合计
        /// </summary>
        public decimal TotalFee { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime SubmitTime { get; set; }

        /// <summary>
        /// 签名 为了支付宝统一故意小写
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 签名类型 为了支付宝统一故意小写
        /// </summary>
        public string sign_type { get; set; }

        /// <summary>
        /// 返回是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
    }
}
