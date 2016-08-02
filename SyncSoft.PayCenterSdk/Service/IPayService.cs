using System.Collections.Generic;
using SyncSoft.PayCenterSdk.Config;
using SyncSoft.PayCenterSdk.Request;
using SyncSoft.PayCenterSdk.Response;

namespace SyncSoft.PayCenterSdk.Service
{
    /// <summary>
    /// 支付接口
    /// </summary>
    public interface IPayService
    {
        /// <summary>
        /// 建立请求 以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        string BuildRequest(PayCenterRequest request, bool isRequest);

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        string QueryOrderInfo(PayCenterRequest request);

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        bool SignVerify(PayCenterRequest request, string sign, bool isGet = true);

        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <param name="des">描述信息</param>
        /// <returns></returns>
        ThirdPayResponse GetResponse(string des);

    }
}
