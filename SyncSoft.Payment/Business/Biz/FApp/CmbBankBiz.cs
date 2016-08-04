using System.Text;
using CMBCHINALib;
using SyncSoft.Payment.Business.Biz.Base;
using SyncSoft.Payment.Business.Interface.Base;
using SyncSoft.Payment.Domain.Request;

namespace SyncSoft.Payment.Business.Biz.FApp
{
    public class CmbBankBiz : BasePayBiz, IBasePayBiz
    {
        private readonly FirmClientClass _cmbBankService = new FirmClientClass();
        public string GetRequestHtml(GetRequestHtmlRequest request)
        {
            var payConfig = request.PartnerPayConfig.CmbBankConfig;

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

            //log.LogInfo(string.Format("招行支付请求：订单号：{0}\r\n", request.OrderNo));
            return builder.ToString();
        }
    }
}
