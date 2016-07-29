using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;
using CMBCHINALib;
using SyncSoft.PayCenterSdk.Config;
using SyncSoft.PayCenterSdk.Model;
using SyncSoft.PayCenterSdk.Request;
using SyncSoft.PayCenterSdk.Response;
using SyncSoft.PayCenterSdk.Tool;

namespace SyncSoft.PayCenterSdk.Service
{
    /// <summary>
    /// 招商银行网银支付
    /// </summary>
    internal class CmbBankService : BasePayService, IPayService
    {

        private readonly FirmClientClass _cmbBankService = new FirmClientClass();

        /// <summary>
        /// 建立请求 以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string BuildRequest(PayCenterRequest request, bool isRequest)
        {
            var payConfig = request.PartnerConfig.CmbBankConfig;

            //签名
            var merchantCode = _cmbBankService.exGenMerchantCode("", request.SubmitTime.ToString("yyyyMMdd"), payConfig.CmbBranchId,
            payConfig.CmbCoNo, request.OrderNo, request.TotalFee.ToString("f2"), "", payConfig.CmbReturnUrl, "", "", "", "", "");

            var builder = new StringBuilder();
            builder.AppendFormat("<form name=\"form\" action=\"{0}\" method=\"post\">",
                payConfig.CmbGateway);
            builder.AppendFormat(" <input type=\"hidden\" name=\"BranchID\" value=\"{0}\" />",
                payConfig.CmbBranchId);
            builder.AppendFormat(" <input type=\"hidden\" name=\"CoNo\" value=\"{0}\" />",
                payConfig.CmbCoNo);
            builder.AppendFormat(" <input type=\"hidden\" name=\"BillNo\" value=\"{0}\" />",
                request.OrderNo);
            builder.AppendFormat(" <input type=\"hidden\" name=\"Amount\" value=\"{0}\" />",
                request.TotalFee.ToString("f2"));
            builder.AppendFormat(" <input type=\"hidden\" name=\"Date\" value=\"{0}\" />",
                request.SubmitTime.ToString("yyyyMMdd"));
            builder.AppendFormat(" <input type=\"hidden\" name=\"MerchantUrl\" value=\"{0}\" />",
                payConfig.CmbReturnUrl);
            builder.AppendFormat(" <input type=\"hidden\" name=\"MerchantReturnUrl\" value=\"{0}\" />",
                payConfig.CmbReturnUrl); //可以不需要，银行默认同上
            builder.AppendFormat(" <input type=\"hidden\" name=\"MerchantCode\" value=\"{0}\" />", merchantCode);
            builder.Append(" </form>");
            builder.Append("<script type=\"text/javascript\">document.form.submit();</script>");

            log.LogInfo(string.Format("招行支付请求：订单号：{0}\r\n", request.OrderNo));
            return builder.ToString();
        }

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        public bool SignVerify(PayCenterRequest request, string sign, bool isGet = true)
        {
            var payConfig = request.PartnerConfig.CmbBankConfig;
            var response = GetResponse("");
            try
            {
                var isNo = _cmbBankService.exCheckInfoFromBank(payConfig.CmbKey, response.CmbBankResponse.UrlParamtersStr);
                if (isNo != 0)
                {
                    var errMsg = _cmbBankService.exGetLastErr(isNo);
               
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }


        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <param name="des">描述信息</param>
        /// <returns></returns>
        public ThirdPayResponse GetResponse(string des)
        {
            var httpResponse = new CmbBankResponse();
            httpResponse.Succeed = HttpContext.Current.Request["Succeed"];
            httpResponse.BillNo = HttpContext.Current.Request["BillNo"];
            httpResponse.Amount = HttpContext.Current.Request["Amount"];
            httpResponse.Msg = HttpContext.Current.Request["Msg"];
            httpResponse.Date = HttpContext.Current.Request["Date"];
            httpResponse.Signature = HttpContext.Current.Request["Signature"];

            var queryString = HttpContext.Current.Request.QueryString.ToString();
            httpResponse.UrlParamtersStr = HttpContext.Current.Server.UrlDecode(queryString);

            var response = new ThirdPayResponse() { CmbBankResponse = httpResponse };
            return response;
        }





    }
}
