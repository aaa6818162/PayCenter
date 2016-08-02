using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayCenterSdk.Model;
using PayCenterSdk.Tool;
using PayCenterSdk.Tool.Md5;

namespace PayCenterSdk
{
    public class PayCenterServer
    {

        /// <summary>
        /// 建立请求，以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetResponseHtml(PayCenterResponse request)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("Partner", request.Partner);
            sParaTemp.Add("UserName", request.UserName);
            sParaTemp.Add("UserId", request.UserId);
            sParaTemp.Add("OrderNo", request.OrderNo);
            sParaTemp.Add("PayRemark", request.PayRemark);
            sParaTemp.Add("PayType", request.PayType.ToString());
            sParaTemp.Add("TotalFee", request.TotalFee.ToString("0.00"));
            sParaTemp.Add("SubmitTime", request.SubmitTime.ToString("yyyy-MM-dd HH:mm:ss"));
            sParaTemp.Add("IsSuccess", request.IsSuccess.ToString());

            //建立请求
            var sHtmlText = new PayCenterMD5Submit(
                payConfig.Gateway, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp, "post", "确认");

            return sHtmlText;
        }

        /// <summary>
        /// 建立请求，以模拟远程HTTP的POST请求方式构造并获取支付的处理结果
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetResponse(PayCenterResponse request)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("Partner", request.Partner);
            sParaTemp.Add("UserName", request.UserName);
            sParaTemp.Add("UserId", request.UserId);
            sParaTemp.Add("OrderNo", request.OrderNo);
            sParaTemp.Add("PayRemark", request.PayRemark);
            sParaTemp.Add("PayType", request.PayType.ToString());
            sParaTemp.Add("TotalFee", request.TotalFee.ToString("0.00"));
            sParaTemp.Add("SubmitTime", request.SubmitTime.ToString("yyyy-MM-dd HH:mm:ss"));
            sParaTemp.Add("IsSuccess", request.IsSuccess.ToString());

            //建立请求
            var result = new PayCenterMD5Submit(
                payConfig.Gateway, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp);
            return result;
        }



        public bool SignVerify(PayCenterResponse request, string sign)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var propertyList = request.GetType().GetProperties();
            var sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("Partner", request.Partner);
            sParaTemp.Add("UserName", request.UserName);
            sParaTemp.Add("UserId", request.UserId);
            sParaTemp.Add("OrderNo", request.OrderNo);
            sParaTemp.Add("PayRemark", request.PayRemark);
            sParaTemp.Add("TotalFee", request.TotalFee.ToString("0.00"));
            sParaTemp.Add("SubmitTime", request.SubmitTime.ToString("yyyy-MM-dd HH:mm:ss"));
            sParaTemp.Add("IsSuccess", request.IsSuccess.ToString());
            return new PayCenterMD5Notify(payConfig.Partner, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).Verify(sParaTemp, sign);
        }

        /// <summary>
        /// 获取客户端请求信息
        /// </summary>
        /// <param name="des"></param>
        /// <returns></returns>
        public PayCenterRequest GetRequest()
        {
            var request = new PayCenterRequest();
            request.Partner = HttpContext.Current.Request["Partner"];
            request.UserName = HttpContext.Current.Request["UserName"];
            request.UserId = HttpContext.Current.Request["UserId"];
            request.OrderNo = HttpContext.Current.Request["OrderNo"];
            request.PayRemark = HttpContext.Current.Request["PayRemark"];
            request.TotalFee = Convert.ToDecimal(HttpContext.Current.Request["TotalFee"]);
            request.SubmitTime = DateTime.Parse(HttpContext.Current.Request["SubmitTime"]);
            request.PayType = (PayEnum)PayEnum.Parse(typeof(PayEnum), HttpContext.Current.Request["PayType"]);
            return request; ;
        }
    }
}
