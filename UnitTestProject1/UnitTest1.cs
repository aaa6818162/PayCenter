using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SyncSoft.Payment;
using SyncSoft.Payment.Business.Interface;
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

            var biz = Container.Resolve<IAlipayBiz>();
            biz.GetRequestHtml(null);
        }
    }
}
