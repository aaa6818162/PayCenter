using SyncSoft.Payment.Business.Interface.Base;
using SyncSoft.Payment.Config;
using SyncSoft.Payment.Domain.Response;

namespace SyncSoft.Payment.Business.Interface.FApp
{
    public interface IAlipayBiz : IBasePayBiz
    {
        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <returns></returns>
        AlipayResponse GetResponse();


        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="response"></param>
        /// <param name="payConfig"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        bool SignVerify(AlipayResponse response, AlipayConfig payConfig, string sign);

        /// <summary>
        /// 通过商户订单号
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <param name="payConfig"></param>
        /// <returns></returns>
        string QueryByOutTradeNo(string outTradeNo, AlipayConfig payConfig);


        /// <summary>
        /// 通过支付宝交易号
        /// </summary>
        /// <param name="tradeNo"></param>
        /// <param name="payConfig"></param>
        /// <returns></returns>
        string QueryByTradeNo(string tradeNo, AlipayConfig payConfig);

    }
}
