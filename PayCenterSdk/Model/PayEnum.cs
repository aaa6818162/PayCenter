using System.ComponentModel;

namespace PayCenterSdk.Model
{
    public enum PayEnum
    {
        /// <summary>
        /// 支付平台
        /// </summary>
        [Description("支付平台")]
        PayCenter = 0,

        /// <summary>
        /// 支付宝
        /// </summary>
        [Description("支付宝")]
        Alipay = 1,
        /// <summary>
        /// 招商银行
        /// </summary>
        [Description("招商银行")]
        CmbBank = 2,
        /// <summary>
        /// 交通银行
        /// </summary>
        [Description("交通银行")]
        CommBank = 3,
        /// <summary>
        /// 工商银行
        /// </summary>
        [Description("工商银行")]
        IcbcBank = 4,
        /// <summary>
        /// 支付宝手机
        /// </summary>
        [Description("支付宝手机")]
        AlipayForMobile = 5,
        /// <summary>
        /// 财付通
        /// </summary>
        [Description("财付通")]
        Tenpay = 6,

        /// <summary>
        /// 支付宝 条码支付
        /// </summary>
        AlipayTM =7,

        /// <summary>
        /// 支付宝 二维码支付
        /// </summary>
        AlipayEW = 8,
    }



}
