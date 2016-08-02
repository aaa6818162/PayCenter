using SyncSoft.Payment.Domain.Request;

namespace SyncSoft.Payment.Business.Interface
{
    public interface IAlipayBiz
    {
        /// <summary>
        /// 建立请求 以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        string GetRequestHtml(AlipayGetRequestHtmlRequest request);

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


        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        bool SignVerify(string request, string sign, bool isGet = true);

        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <param name="des">描述信息</param>
        /// <returns></returns>
        string GetResponse(string des);
    }
}
