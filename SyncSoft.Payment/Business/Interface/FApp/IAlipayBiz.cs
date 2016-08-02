using SyncSoft.Payment.Config;
using SyncSoft.Payment.Domain.Request;
using SyncSoft.Payment.Domain.Response;

namespace SyncSoft.Payment.Business.Interface
{
    public interface IAlipayBiz : IBasePayBiz
    {
        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <param name="des">描述信息</param>
        /// <returns></returns>
        AlipayResponse GetResponse(string des);


        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        bool SignVerify(AlipayConfig payConfig, string sign, string notify_id, bool isGet = true);

        /// <summary>
        /// 通过商户订单号
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        string QueryByOutTradeNo(string outTradeNo);


        /// <summary>
        /// 通过支付宝交易号
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        string QueryByTradeNo(string outTradeNo);

    }
}
