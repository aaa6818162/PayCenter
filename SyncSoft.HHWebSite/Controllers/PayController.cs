using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayCenterSdk;
using PayCenterSdk.Model;

namespace SyncSoft.HHWebSite.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Fail()
        {
            return View();
        }


        /// <summary>
        /// 同步
        /// </summary>
        /// <returns></returns>
        public ActionResult PayResult()
        {
            var request = new PayCenterClient().GePayCenterResponse();

            //if (string.IsNullOrEmpty(t.sign)
            //    || string.IsNullOrEmpty(t.sign_type)
            //    || string.IsNullOrEmpty(t.OrderNo)
            //    || string.IsNullOrEmpty(t.Partner)
            //    || string.IsNullOrEmpty(t.UserId)
            //    || string.IsNullOrEmpty(t.UserName)
            //    || string.IsNullOrEmpty(t.PayRemark)
            //    )
            //{
            //    ViewBag.Message = "当前交易请求缺少必要的参数";
            //    return View();
            //}

            //if ((DateTime.Now - submittime).TotalSeconds > 60)
            //{
            //    ViewBag.Message = "当前交易请求已超时";
            //    return View();
            //}

            request.PayCenterConfig = DataAccess.GetPayCenterConfig();


            //验证数据是否已被篡改
            if (!new PayCenterClient().SignVerify(request, Request["sign"]))
            {
                ViewBag.Message = "数据已被篡改";
                return View();
            }

            if (!request.IsSuccess)
            {
                return View("Fail");

            }

            return View("Success");
        }

        /// <summary>
        /// 异步
        /// </summary>
        /// <returns></returns>
        public ActionResult PayResultNotify()
        {

            return View();
        }

    }
}