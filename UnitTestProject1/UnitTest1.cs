using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SyncSoft.Payment;
using SyncSoft.Payment.Business.Interface;
using SyncSoft.Payment.Business.Interface.Base;
using SyncSoft.Payment.Business.Interface.FApp;
using SyncSoft.Payment.IOC;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bootstrap.Register();

            var biz = Container.Resolve<IBasePayBiz>("Alipay");

            biz.GetRequestHtml(null);


            var biz2 = Container.Resolve<IBasePayBiz>("CmbBank");

            biz2.GetRequestHtml(null);
        }
    }
}
