using System;
using PayCenterSdk.Model;

namespace PayCenterSdk
{
    /// <summary>
    /// 
    /// </summary>
    public class PayCenterRequest
    {
        /// <summary>
        /// 支付平台商户号
        /// </summary>
        public string Partner { get; set; }

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
        /// 默认支付平台
        /// </summary>
        public PayEnum PayType { get; set; }

        /// <summary>
        /// 支付配置信息
        /// </summary>
        public PayCenterConfig PayCenterConfig { get; set; }


        public Tuple<bool, string> Validate()
        {
            var msg = "当前交易请求缺少必要的参数";
            if (string.IsNullOrEmpty(Partner))
            {
                msg += "Partner";
                return new Tuple<bool, string>(true, msg);
            }
            return new Tuple<bool, string>(true, "");
        }

        #region
        /// <summary>
        /// 淘宝动态Id
        /// </summary>
        public string Ext_dynamic_id { get; set; }
        #endregion
    }
}
