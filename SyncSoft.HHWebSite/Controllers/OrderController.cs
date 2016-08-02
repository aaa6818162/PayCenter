using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayCenterSdk;
using PayCenterSdk.Model;


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
            request.PayType = PayEnum;
            string requestFrom = new PayCenterClient().GetRequestHtml(request);

            return Content(requestFrom);
        }
    }
}