using System.Collections.Generic;
using AlipaySdk.Md5;
using SyncSoft.Payment.Business.Interface;
using SyncSoft.Payment.Domain.Request;

namespace SyncSoft.Payment.Business.Biz
{
    /// <summary>
    /// 支付宝非应用端
    /// </summary>
    public class AlipayBiz :BasePayBiz, IAlipayBiz
    {
        #region Implementation of IAlipayBiz

        /// <summary>
        /// 建立请求 以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetRequestHtml(AlipayGetRequestHtmlRequest request)
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
            sParaTemp.Add("out_trade_no", request.OrderModel.OrderNo);
            sParaTemp.Add("subject", request.OrderModel.PayRemark);
            sParaTemp.Add("total_fee", request.OrderModel.TotalFee.ToString("0.00"));
            sParaTemp.Add("body", request.OrderModel.PayRemark);
            sParaTemp.Add("show_url", "");
            sParaTemp.Add("anti_phishing_key", "");//防钓鱼时间戳
            sParaTemp.Add("exter_invoke_ip", "");//客户端的IP地址
            //建立请求
            var sHtmlText = new AlipayMd5Submit(payConfig.Key, payConfig.InputCharset,payConfig.SignType).BuildRequest(sParaTemp, "post", "确认");

            log.LogInfo(sHtmlText);
            return sHtmlText;
        }

        /// <summary>
        /// 通过商户订单号
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        public string QueryByOutTradeNo(string outTradeNo)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 通过支付宝交易号
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        public string QueryByTradeNo(string outTradeNo)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        public bool SignVerify(string request, string sign, bool isGet = true)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <param name="des">描述信息</param>
        /// <returns></returns>
        public string GetResponse(string des)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
