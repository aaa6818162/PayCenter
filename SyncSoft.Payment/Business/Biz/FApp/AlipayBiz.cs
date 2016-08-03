using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;
using AlipaySdk.Md5;
using SyncSoft.Payment.Business.Biz.Base;
using SyncSoft.Payment.Business.Interface;
using SyncSoft.Payment.Business.Interface.FApp;
using SyncSoft.Payment.Config;
using SyncSoft.Payment.Domain.Request;
using SyncSoft.Payment.Domain.Response;

namespace SyncSoft.Payment.Business.Biz.FApp
{
    /// <summary>
    /// 支付宝非应用端
    /// </summary>
    public class AlipayBiz : BasePayBiz, IAlipayBiz
    {
        #region Implementation of IAlipayBiz

        /// <summary>
        /// 建立请求 以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetRequestHtml(GetRequestHtmlRequest request)
        {
            var payConfig = request.PartnerPayConfig.AlipayConfig;

            //把请求参数打包成数组 
            var sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("partner", payConfig.Partner);
            sParaTemp.Add("_input_charset", payConfig.InputCharset.ToLower());
            sParaTemp.Add("service", "create_direct_pay_by_user");
            sParaTemp.Add("payment_type", "1");
            sParaTemp.Add("notify_url", payConfig.NotifyUrl);
            sParaTemp.Add("return_url", payConfig.ReturnUrl);
            sParaTemp.Add("seller_email", payConfig.SellerEmail);
            sParaTemp.Add("out_trade_no", request.OrderNo);
            sParaTemp.Add("subject", request.PayRemark);
            sParaTemp.Add("total_fee", request.TotalFee.ToString("0.00"));
            sParaTemp.Add("body", "支付平台商户号：" + request.PayCenterPartner);
            sParaTemp.Add("show_url", "");
            sParaTemp.Add("anti_phishing_key", "");//防钓鱼时间戳
            sParaTemp.Add("exter_invoke_ip", "");//客户端的IP地址
            //建立请求
            var sHtmlText = new AlipayMd5Submit(payConfig.Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp, "post", "确认");

            log.LogInfo(sHtmlText);
            return sHtmlText;
        }

        /// <summary>
        /// 通过商户订单号
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <param name="payConfig"></param>
        /// <returns></returns>
        public string QueryByOutTradeNo(string outTradeNo, AlipayConfig payConfig)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("partner", payConfig.Partner);
            sParaTemp.Add("_input_charset", payConfig.InputCharset.ToLower());
            sParaTemp.Add("service", "single_trade_query");
            sParaTemp.Add("trade_no", "");//支付宝交易号
            sParaTemp.Add("out_trade_no", outTradeNo);//商户订单号：

            //建立请求
            string sHtmlText = new AlipayMd5Submit(payConfig.Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp);
            return sHtmlText;
        }

        /// <summary>
        /// 通过支付宝交易号
        /// </summary>
        /// <param name="tradeNo"></param>
        /// <param name="payConfig"></param>
        /// <returns></returns>
        public string QueryByTradeNo(string tradeNo, AlipayConfig payConfig)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("partner", payConfig.Partner);
            sParaTemp.Add("_input_charset", payConfig.InputCharset.ToLower());
            sParaTemp.Add("service", "single_trade_query");
            sParaTemp.Add("trade_no", tradeNo);//支付宝交易号
            sParaTemp.Add("out_trade_no", "");//商户订单号：

            //建立请求
            string sHtmlText = new AlipayMd5Submit(payConfig.Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp);
            return sHtmlText;
        }


        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="payConfig"></param>
        /// <param name="sign"></param>
        /// <param name="notify_id"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        public bool SignVerify(AlipayResponse response,  AlipayConfig payConfig, string sign)
        {
            var sArray = new SortedDictionary<string, string>();
            sArray.Add("body", response.body);
            sArray.Add("buyer_email", response.buyer_email);
            sArray.Add("buyer_id", response.buyer_id);
            sArray.Add("exterface", response.exterface);
            sArray.Add("is_success", response.is_success);
            sArray.Add("notify_id", response.notify_id);
            sArray.Add("notify_time", response.notify_time);
            sArray.Add("notify_type", response.notify_type);
            sArray.Add("out_trade_no", response.out_trade_no);
            sArray.Add("payment_type", response.payment_type);
            sArray.Add("seller_email", response.seller_email);
            sArray.Add("seller_id", response.seller_id);
            sArray.Add("subject", response.subject);
            sArray.Add("total_fee", response.total_fee);
            sArray.Add("trade_no", response.trade_no);
            sArray.Add("trade_status", response.trade_status);
            sArray.Add("sign", response.sign);
            sArray.Add("sign_type", response.sign_type);
            //var sArray = GetRequestGet();
            return new AlipayMd5Notify(payConfig.Partner, payConfig.Key, payConfig.InputCharset, payConfig.SignType).Verify(sArray, response.notify_id, sign);
        }

        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <returns></returns>
        public AlipayResponse GetResponse()
        {
            var alipayResponse = new AlipayResponse();
            alipayResponse.body = HttpContext.Current.Request["body"];
            alipayResponse.buyer_email = HttpContext.Current.Request["buyer_email"];
            alipayResponse.buyer_id = HttpContext.Current.Request["buyer_id"];
            alipayResponse.exterface = HttpContext.Current.Request["exterface"];
            alipayResponse.is_success = HttpContext.Current.Request["is_success"];
            alipayResponse.notify_id = HttpContext.Current.Request["notify_id"];
            alipayResponse.notify_time = HttpContext.Current.Request["notify_time"];
            alipayResponse.notify_type = HttpContext.Current.Request["notify_type"];
            alipayResponse.out_trade_no = HttpContext.Current.Request["out_trade_no"];
            alipayResponse.payment_type = HttpContext.Current.Request["payment_type"];
            alipayResponse.seller_email = HttpContext.Current.Request["seller_email"];
            alipayResponse.seller_id = HttpContext.Current.Request["seller_id"];
            alipayResponse.subject = HttpContext.Current.Request["subject"];
            alipayResponse.total_fee = HttpContext.Current.Request["total_fee"];
            alipayResponse.trade_no = HttpContext.Current.Request["trade_no"];
            alipayResponse.trade_status = HttpContext.Current.Request["trade_status"];
            alipayResponse.sign = HttpContext.Current.Request["sign"];
            alipayResponse.sign_type = HttpContext.Current.Request["sign_type"];
            return alipayResponse;
        }


        #region
        /// <summary>
        /// 获取支付宝POST过来通知消息，并以“参数名=参数值”的形式组成数组
        /// </summary>
        /// <returns>request回来的信息组成的数组</returns>
        private SortedDictionary<string, string> GetRequestPost()
        {
            int i = 0;
            SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
            NameValueCollection coll;
            //Load Form variables into NameValueCollection variable.
            coll = HttpContext.Current.Request.Form;
            // Get names of all forms into a string array.
            String[] requestItem = coll.AllKeys;
            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], HttpContext.Current.Request.Form[requestItem[i]]);
            }
            return sArray;
        }

        /// <summary>
        /// 获取支付宝GET过来通知消息，并以“参数名=参数值”的形式组成数组
        /// </summary>
        /// <returns>request回来的信息组成的数组</returns>
        private SortedDictionary<string, string> GetRequestGet()
        {
            int i = 0;
            SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
            NameValueCollection coll;
            //Load Form variables into NameValueCollection variable.
            coll = HttpContext.Current.Request.QueryString;
            // Get names of all forms into a string array.
            String[] requestItem = coll.AllKeys;

            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], HttpContext.Current.Request.QueryString[requestItem[i]]);
            }
            return sArray;
        }
        #endregion

        #endregion
    }
}
