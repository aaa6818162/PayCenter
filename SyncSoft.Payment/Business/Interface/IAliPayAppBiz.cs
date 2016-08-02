namespace SyncSoft.Payment.Business.Interface
{
    /// <summary>
    /// 支付宝应用端接口
    /// </summary>
    public interface IAliPayAppBiz:IBaseAppBiz
    {
        //当面付条码支付
        void tradePay(string builder);

        // 当面付2.0交易查询通过商户订单号
        void tradeQuery(string outTradeNo);
        // 当面付2.0交易查询通过支付宝交易号
        void tradeQueryByAilipayNo(string TradeNo);


        // 当面付2.0交易退货
        void tradeRefund(string builder);

        // 当面付2.0预下单
        void tradePrecreate(string builder);
        void tradePrecreate(string builder, string notify_url);
    }
}
