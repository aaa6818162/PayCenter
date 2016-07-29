namespace SyncSoft.PayCenterSdk.Config
{
    /// <summary>
    /// 平台配置信息
    /// </summary>
    public class PartnerConfig
    {
        /// <summary>
        /// 支付中心
        /// </summary>
        public PayCenterConfig PayCenterConfig { get; set; }

        /// <summary>
        ///支付宝
        /// </summary>
        public AlipayConfig AlipayConfig { get; set; }

        /// <summary>
        /// 招商银行
        /// </summary>
        public CmbBankConfig CmbBankConfig { get; set; }

        /// <summary>
        /// 交通银行
        /// </summary>
        public CommBankConfig CommBankConfig { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public IcbcBankConfig IcbcBankConfig { get; set; }

        /// <summary>
        /// 财付通
        /// </summary>
        public TenpayConfig TenpayConfig { get; set; }

    }



}
