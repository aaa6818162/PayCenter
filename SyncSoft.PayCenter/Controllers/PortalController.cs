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
using SyncSoft.Payment.Business.Biz.App;
using SyncSoft.Payment.Business.Biz.FApp;
using SyncSoft.Payment.Business.Interface;
using SyncSoft.Payment.Business.Interface.Base;
using SyncSoft.Payment.Domain.Request;
using SyncSoft.Payment.IOC;

//using SyncSoft.PayCenterSdk;
//using SyncSoft.PayCenterSdk.Model;
//using SyncSoft.PayCenterSdk.Request;
//using SyncSoft.PayCenterSdk.Response;

namespace SyncSoft.PayCenter.Controllers
{
    public class PortalController : Controller
    {
        ILogBiz log = new LogBiz();
        public ActionResult Pay()
        {
            return View();
        }

        public ActionResult ConfrimPay(PayEnum PayType)
        {
            var payCenterRequest = TestDictionary.GetTestByPartnerId();
            var request = new GetRequestHtmlRequest();
            request.Partner = payCenterRequest.OrderNo;
            request.PayCenterPartner = payCenterRequest.Partner;
            request.UserName = payCenterRequest.UserName;
            request.UserId = payCenterRequest.UserId;
            request.OrderNo = payCenterRequest.OrderNo;
            request.PayRemark = payCenterRequest.PayRemark;
            request.TotalFee = payCenterRequest.TotalFee;
            request.SubmitTime = payCenterRequest.SubmitTime;
            request.PartnerPayConfig.AlipayConfig = SyncSoft.Payment.DataAccess.GetAlipayConfig();
            var requestFrom = Container.Resolve<IBasePayBiz>(payCenterRequest.PayType.ToString()).GetRequestHtml(request);

            log.LogInfo(requestFrom);

            return Content(requestFrom);
            return View();
        }

        /// <summary>
        /// 这里到时候拆分成移动支付 和pc支付
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index()
        {

            var payCenterRequest = new PayCenterServer().GetRequest();

            log.LogInfo(payCenterRequest);

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
            if (!new PayCenterServer().SignVerify(payCenterRequest, Request["Sign"]))
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

                if (payCenterRequest.PayType == PayEnum.AlipayTM)
                {

                    var result = new AliPayAppBiz().tradePay(Request["Ext_dynamic_id"]);
                    var payCenterResponse = new PayCenterResponse();
                    payCenterResponse.Partner = "111";
                    payCenterResponse.OrderNo = result.OrderNo;
                    payCenterResponse.PayType = PayEnum.AlipayTM;
                    payCenterResponse.ThridPaySerialNumber = result.ThridPaySerialNo;
                    payCenterResponse.PayCenterSerialNumber = DateTime.Now.ToString();
                    payCenterResponse.PayTime = result.PayTime;
                    payCenterResponse.IsSuccess = result.IsSuccess;
   
                    return Content(JsonConvert.SerializeObject(payCenterResponse));

                }
                else
                {
                    var request = new GetRequestHtmlRequest();
                    request.Partner = payCenterRequest.OrderNo;
                    request.PayCenterPartner = payCenterRequest.Partner;
                    request.UserName = payCenterRequest.UserName;
                    request.UserId = payCenterRequest.UserId;
                    request.OrderNo = payCenterRequest.OrderNo;
                    request.PayRemark = payCenterRequest.PayRemark;
                    request.TotalFee = payCenterRequest.TotalFee;
                    request.SubmitTime = payCenterRequest.SubmitTime;
                    request.PartnerPayConfig.AlipayConfig = SyncSoft.Payment.DataAccess.GetAlipayConfig();
                    var requestFrom = Container.Resolve<IBasePayBiz>(payCenterRequest.PayType.ToString()).GetRequestHtml(request);
                    return Content(requestFrom);
                }

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
            var entity = new AlipayBiz().GetResponse();
            //获取配置信息
            var config = SyncSoft.Payment.DataAccess.GetAlipayConfig();

            if (!new AlipayBiz().SignVerify(entity, config, entity.sign))
            {
                ViewBag.Message = "数据已被篡改";
                return View();
            }

            if (!entity.IsSuccess)
            {
                ViewBag.Message = "交易失败";
                return View();
            }

            var payCenterResponse = new PayCenterResponse();
            payCenterResponse.Partner = "111";
            payCenterResponse.OrderNo = entity.out_trade_no;
            payCenterResponse.PayType = PayEnum.Alipay;
            payCenterResponse.ThridPaySerialNumber = entity.trade_no;
            payCenterResponse.PayCenterSerialNumber = DateTime.Now.ToString();
            payCenterResponse.PayTime = DateTime.Now.ToString();
            payCenterResponse.IsSuccess = entity.IsSuccess;
            payCenterResponse.PayCenterConfig = PayCenterSdk.DataAccessClient.GetPayCenterConfig();
            string requestFrom = new PayCenterServer().GetResponseHtml(payCenterResponse);
            return Content(requestFrom);
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