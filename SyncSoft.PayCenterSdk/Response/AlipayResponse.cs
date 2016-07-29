namespace SyncSoft.PayCenterSdk.Response
{
    /// <summary>
    /// 支付宝返回信息
    /// </summary>
    public class AlipayResponse
    {
        /// <summary>
        /// 通知验证ID notify_id
        /// </summary>
        public string NotifyId { get; set; }

        /// <summary>
        /// 支付宝生成的签名结果sign
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 商户订单号out_trade_no
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// seller_email 商家账号
        /// </summary>
        public string PartnerEmail { get; set; }

        /// <summary>
        /// 商家Id
        /// </summary>
        public string Partner { get; set; }


        /// <summary>
        /// 支付宝交易号 trade_no
        /// </summary>
        public string PaySerialNumber { get; set; }

        /// <summary>
        /// gmt_payment 支付日期
        /// </summary>
        public string PayDate { get; set; }

        /// <summary>
        /// price
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        ///交易状态 trade_status
        /// </summary>
        public string TradeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                if (TradeStatus == "WAIT_SELLER_SEND_GOODS" || TradeStatus == "TRADE_FINISHED" ||
                       TradeStatus == "TRADE_SUCCESS")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
