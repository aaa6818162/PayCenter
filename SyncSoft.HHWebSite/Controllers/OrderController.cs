using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PayCenterSdk;
using PayCenterSdk.Model;


namespace SyncSoft.HHWebSite.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            //new PayCenterClient().GetPayCenterConfig(  "1111","http://localhost:24131/api/PayCenterConfig/GetPayCenterConfig?"
            //  );
            return View();
        }

        public ActionResult Index2()
        {
            //new PayCenterClient().GetPayCenterConfig(  "1111","http://localhost:24131/api/PayCenterConfig/GetPayCenterConfig?"
            //  );
            return View();
        }

        public ActionResult Confirm(PayEnum PayEnum)
        {
            PayCenterRequest request = TestDictionary.GetTestByPartnerId();
            request.PayType = PayEnum;
            string requestFrom = new PayCenterClient().GetRequestHtml(request);

            return Content(requestFrom);
        }


        public ActionResult Confirm2(PayEnum PayEnum)
        {
            PayCenterRequest request = TestDictionary.GetTestByPartnerId();
            request.PayType = PayEnum;
            request.Ext_dynamic_id = Request["Ext_dynamic_id"];
            string requestFrom = new PayCenterClient().GetRequest(request);

            var result = JsonConvert.DeserializeObject<PayCenterResponse>(requestFrom);

            if (!result.IsSuccess)
            {
                return RedirectToAction("Fail", "Pay");
            }
            return RedirectToAction("Success", "Pay");
        }


        public ActionResult Confirm3()
        {
            return RedirectToAction("Success", "Pay");
        }

    }
}