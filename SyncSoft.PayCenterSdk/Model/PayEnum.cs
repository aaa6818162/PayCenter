using System.ComponentModel;

namespace SyncSoft.PayCenterSdk.Model
{
    public enum PayEnum
    {
        /// <summary>
        /// 支付宝
        /// </summary>
        [Description("支付宝")]
        Alipay = 0,
        /// <summary>
        /// 招商银行
        /// </summary>
        [Description("招商银行")]
        CmbBank = 1,
        /// <summary>
        /// 交通银行
        /// </summary>
        [Description("交通银行")]
        CommBank = 2,
        /// <summary>
        /// 工商银行
        /// </summary>
        [Description("工商银行")]
        IcbcBank = 3,
        /// <summary>
        /// 支付宝手机
        /// </summary>
        [Description("支付宝手机")]
        AlipayForMobile = 4,
        /// <summary>
        /// 财付通
        /// </summary>
        [Description("财付通")]
        Tenpay = 5,

        /// <summary>
        /// 支付平台
        /// </summary>
        [Description("支付平台")]
        PayCenter = 6,


    }
}
