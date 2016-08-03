using SyncSoft.Payment.Domain.Request;

namespace SyncSoft.Payment.Business.Interface.Base
{
    /// <summary>
    /// 非移动端
    /// </summary>
    public interface IBasePayBiz
    {
        /// <returns></returns>
        string GetRequestHtml(GetRequestHtmlRequest request);

    }
}
