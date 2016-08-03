using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SyncSoft.Payment.Business.Biz;
using SyncSoft.Payment.Business.Biz.FApp;
using SyncSoft.Payment.Business.Interface;
using SyncSoft.Payment.Business.Interface.Base;
using SyncSoft.Payment.Business.Interface.FApp;
using SyncSoft.Payment.IOC;
[assembly: PreApplicationStartMethod(typeof(SyncSoft.Payment.Bootstrap), "Register")] 
namespace SyncSoft.Payment
{
    /// <summary>
    /// 看看又没办法应用程序集就调用 详见webapi startup
    /// </summary>
    public static class Bootstrap
    {
        public static void Register()
        {
            Container.Register<IBasePayBiz, AlipayBiz>("Alipay");
            Container.Register<IBasePayBiz, CmbBankBiz>("CmbBank");
        }
    }
}
