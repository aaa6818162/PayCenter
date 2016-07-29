using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SyncSoft.PayCenterSdk;
using SyncSoft.PayCenterSdk.Model;
using SyncSoft.PayCenterSdk.Request;

namespace SyncSoft.HHWebSite.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Confirm(PayEnum PayEnum)
        {
            PayCenterRequest request = TestDictionary.GetTestByPartnerId();

            string requestFrom = new PayCenterClient(PayEnum).GetRequestHtml(request);

            return Content(requestFrom);
        }
    }
}