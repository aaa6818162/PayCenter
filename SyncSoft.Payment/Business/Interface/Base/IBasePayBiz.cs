using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.Payment.Domain.Request;

namespace SyncSoft.Payment.Business.Interface
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
