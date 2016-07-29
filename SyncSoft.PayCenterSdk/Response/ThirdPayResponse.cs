namespace SyncSoft.PayCenterSdk.Response
{
    public class ThirdPayResponse
    {  /// <summary>
        /// 支付中心
        /// </summary>
        public PayCenterResponse PayCenterResponse { get; set; }

        /// <summary>
        ///支付宝
        /// </summary>
        public AlipayResponse AlipayResponse { get; set; }

        /// <summary>
        /// 招商银行
        /// </summary>
        public CmbBankResponse CmbBankResponse { get; set; }

        /// <summary>
        /// 交通银行
        /// </summary>
        public CommBankResponse CommBankResponse { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public IcbcBankResponse IcbcBankResponse { get; set; }

        /// <summary>
        /// 财付通
        /// </summary>
        public TenpayResponse TenpayResponse { get; set; }
    }
}
