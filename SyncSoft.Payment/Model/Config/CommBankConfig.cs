namespace SyncSoft.Payment.Config
{
    /// <summary>
    /// 交通银行支付实体
    /// </summary>
    public class CommBankConfig
    {
        public CommBankConfig()
        {
            InterfaceVersion = "1.0.0.0";
            TranType = "0";
            NetType = "0";
            CurType = "CNY";
            //TranCode = "cb2200_sign";
        }

        /// <summary>
        /// IP
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        public string MerId { get; set; }
        /// <summary>
        /// 交行网关地址
        /// </summary>
        public string OrderUrl { get; set; }
        /// <summary>
        /// 签名认证信息
        /// </summary>
        public string SignMsg { get; set; }
        /// <summary>
        /// 消息版本号
        /// </summary>
        public string InterfaceVersion { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string Orderid { get; set; }
        /// <summary>
        /// 商户订单日期
        /// </summary>
        public string OrderDate { get; set; }
        /// <summary>
        /// 商户订单时间
        /// </summary>
        public string OrderTime { get; set; }
        /// <summary>
        /// 交易类别
        /// </summary>
        public string TranType { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public string Amount { get; set; }
        /// <summary>
        /// 交易币种
        /// </summary>
        public string CurType { get; set; }
        /// <summary>
        /// 订单内容
        /// </summary>
        public string OrderContent { get; set; }
        /// <summary>
        /// 商家备注
        /// </summary>
        public string OrderMono { get; set; }
        /// <summary>
        /// 物流配送标志
        /// </summary>
        public string PhdFlag { get; set; }
        /// <summary>
        /// 通知方式0 不通知 1 通知 2 抓取页面
        /// </summary>
        public string NotifyType { get; set; }
        /// <summary>
        /// 主动通知URL 
        /// </summary>
        public string MerUrl { get; set; }
        /// <summary>
        /// 取货URL 
        /// </summary>
        public string GoodsUrl { get; set; }
        /// <summary>
        /// 自动跳转时间
        /// </summary>
        public string JumpSeconds { get; set; }
        /// <summary>
        /// 商户批次号
        /// </summary>
        public string PayBatchNo { get; set; }
        /// <summary>
        /// 代理商家名称
        /// </summary>
        public string ProxyMerName { get; set; }
        /// <summary>
        /// 代理商家类型 
        /// </summary>
        public string ProxyMerType { get; set; }
        /// <summary>
        /// 代理商家证件号码
        /// </summary>
        public string ProxyMercredentials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NetType { get; set; }
        /// <summary>
        /// 渠道编号
        /// </summary>
        public string IssBankNo { get; set; }
        /// <summary>
        /// 发卡行行号
        /// </summary>
        public string TranCode { get; set; }

    }
}
