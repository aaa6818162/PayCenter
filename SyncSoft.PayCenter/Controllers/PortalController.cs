using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PayCenterSdk;
using PayCenterSdk.Model;
using SyncSoft.Payment;
using SyncSoft.Payment.Business.Biz;
using SyncSoft.Payment.Business.Biz.FApp;
using SyncSoft.Payment.Domain.Request;

//using SyncSoft.PayCenterSdk;
//using SyncSoft.PayCenterSdk.Model;
//using SyncSoft.PayCenterSdk.Request;
//using SyncSoft.PayCenterSdk.Response;

namespace SyncSoft.PayCenter.Controllers
{
    public class PortalController : Controller
    {

        public ActionResult Pay()
        {
            return View();
        }

        //public ActionResult ConfrimPay(PayEnum PayType)
        //{
        //    //建立请求
        //    PayCenterRequest request = TestDictionary.GetTestByPartnerId();
        //    string requestFrom = new PayCenterClient(PayType).GetRequestHtml(request);
        //    return Content(requestFrom);
        //}


        public ActionResult Index()
        {
            var payCenterRequest = new PayCenterServer().GetRequest();

            var validateResult = payCenterRequest.Validate();
            if (!validateResult.Item1)
            {
                ViewBag.Message = validateResult.Item2;
                return View();
            }

            //if ((DateTime.Now - submittime).TotalSeconds > 60)
            //{
            //    ViewBag.Message = "当前交易请求已超时";
            //    return View();
            //}

            payCenterRequest.PayCenterConfig = TestDictionary.GetTestByPartnerId().PayCenterConfig;

            //验证数据是否已被篡改
            if (!new PayCenterClient().SignVerify(payCenterRequest, Request["Sign"]))
            {
                ViewBag.Message = "数据已被篡改";
                return View();
            }

            if (payCenterRequest.PayType == PayEnum.PayCenter)
            {
                return View("Pay");
            }
            else
            {
                switch (payCenterRequest.PayType)
                {
                    case PayEnum.Alipay:
                        var request = new GetRequestHtmlRequest();
                        request.Partner = payCenterRequest.OrderNo;
                        request.PayCenterPartner = payCenterRequest.Partner;
                        request.UserName = payCenterRequest.UserName;
                        request.UserId = payCenterRequest.UserId;
                        request.OrderNo = payCenterRequest.OrderNo;
                        request.PayRemark = payCenterRequest.PayRemark;
                        request.TotalFee = payCenterRequest.TotalFee;
                        request.SubmitTime = payCenterRequest.SubmitTime;
                        request.PartnerPayConfig.AlipayConfig = DataAccess.GetAlipayConfig();

                        var requestFrom = new AlipayBiz().GetRequestHtml(request);

                        return Content(requestFrom);
            
                }



                //建立请求
                //PayCenterRequest request = TestDictionary.GetTestByPartnerId();
                //string requestFrom = new PayCenterClient(PayType).GetRequestHtml(request);
                //return Content(requestFrom);
                return View();
            }
        }

        /// <summary>
        /// 移动端接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AppIndex()
        {
            return View();
        }


        //public ActionResult Index(string request )
        //{
        //    var reuestEntity = JsonConvert.DeserializeObject<PayCenterRequest>(request);

        //    if ((DateTime.Now - reuestEntity.SubmitTime).TotalSeconds > 60)
        //    {
        //        ViewBag.Message = "当前交易请求已超时";
        //        return View();
        //    }

        //    //验证数据是否已被篡改
        //    if (!new PayCenterClient(reuestEntity.PayType).SignVerify(reuestEntity, reuestEntity.Sign))
        //    {
        //        ViewBag.Message = "数据已被篡改";
        //        return View();
        //    }


        //    return View("Pay");
        //}





        #region 回调页面

        /// <summary>
        /// 支付宝同步处理
        /// </summary>
        /// <returns></returns>

        public ActionResult AlipayReturn()
        {
            //var entity = new PayCenterClient(PayEnum.Alipay).GetRequestResult("支付宝同步");
            ////获取配置信息
            //PayCenterRequest request = TestDictionary.GetTestByPartnerId(entity.AlipayResponse.Partner);
            //request.ThirdPayResponse = entity;

            //if (!new PayCenterClient(PayEnum.Alipay).SignVerify(request, entity.AlipayResponse.Sign))
            //{
            //    ViewBag.Message = "数据已被篡改";
            //    return View();
            //}

            //if (!entity.AlipayResponse.IsSuccess)
            //{
            //    ViewBag.Message = "交易失败";
            //    return View();
            //}

            //request.IsSuccess = true;

            //string requestFrom = new PayCenterClient(PayEnum.PayCenter).GetRequestHtml(request, false);
            //return Content(requestFrom);
            return View();
        }

        /// <summary>
        /// 支付宝异步处理
        /// </summary>
        /// <returns></returns>
        public ActionResult AlipayNotify()
        {
            //调用远程方法

            //var result = _payFactory.CheckNotifyData(PayEnum.Alipay, NotifyEnum.POST);
            //if (result.Status)
            //{
            //    ConfirmOrder(result);
            //}
            //return Content(result.Message);
            return View();
        }


        public ActionResult CmbReturn()
        {
            //var entity = new PayCenterClient(PayEnum.CmbBank).GetRequestResult("支付宝同步");
            ////获取配置信息
            //PayCenterRequest request = TestDictionary.GetTestByPartnerId("");
            //request.ThirdPayResponse = entity;

            //if (!new PayCenterClient(PayEnum.CmbBank).SignVerify(request, entity.CmbBankResponse.Signature))
            //{

            //}

            return View();
        }

        #endregion




    }
}