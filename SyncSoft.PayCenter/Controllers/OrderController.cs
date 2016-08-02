using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using SyncSoft.PayCenterSdk;
//using SyncSoft.PayCenterSdk.Model;
//using SyncSoft.PayCenterSdk.Service;

namespace SyncSoft.PayCenter.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            //var request = TestDictionary.GetTestByPartnerId();
            //new AlipayService().QueryOrderInfo(request);
            return View();
        }
    }
}