using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.PayCenterSdk.Request;

namespace SyncSoft.PayCenterSdk
{
    public interface IPayCenterClient
    {
        /// <summary>
        /// 提交表单HTML文本
        /// </summary>
        /// <returns></returns>
        string GetRequestHtml(PayCenterRequest request);

        /// <summary>
        /// 处理结果
        /// </summary>
        /// <returns></returns>
        string GetRequestResult(PayCenterRequest request);

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <returns></returns>
        bool SignVerify();
    }
}
