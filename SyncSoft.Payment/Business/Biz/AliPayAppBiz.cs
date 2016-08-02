using SyncSoft.Payment.Business.Interface;

namespace SyncSoft.Payment.Business.Biz
{
    /// <summary>
    /// 支付宝应用端接口
    /// </summary>
    public class AliPayAppBiz : IAliPayAppBiz
    {
        #region Implementation of IAliPayAppBiz

        public void tradePay(string builder)
        {
            throw new System.NotImplementedException();
        }

        public void tradeQuery(string outTradeNo)
        {
            throw new System.NotImplementedException();
        }

        public void tradeQueryByAilipayNo(string TradeNo)
        {
            throw new System.NotImplementedException();
        }

        public void tradeRefund(string builder)
        {
            throw new System.NotImplementedException();
        }

        public void tradePrecreate(string builder)
        {
            throw new System.NotImplementedException();
        }

        public void tradePrecreate(string builder, string notify_url)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
