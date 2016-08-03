using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayCenterSdk.Tool;
using PayCenterSdk.Tool.Md5;

namespace PayCenterSdk
{
    /// <summary>
    /// 移动支付
    /// </summary>
    public class PayCenterAppClient
    {


        /// <summary>
        /// 建立请求，以模拟远程HTTP的POST请求方式构造并获取支付的处理结果
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetRequest(PayCenterRequest request)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("Partner", request.Partner);
            sParaTemp.Add("UserName", request.UserName);
            sParaTemp.Add("UserId", request.UserId);
            sParaTemp.Add("OrderNo", request.OrderNo);
            sParaTemp.Add("PayRemark", request.PayRemark);
            sParaTemp.Add("TotalFee", request.TotalFee.ToString("0.00"));
            sParaTemp.Add("SubmitTime", request.SubmitTime.ToString("yyyy-MM-dd HH:mm:ss"));

            //建立请求
            var result = new PayCenterMD5Submit(
                payConfig.Gateway, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp);
            return result;
        }



        public bool SignVerify(PayCenterRequest request, string sign)
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
            return new PayCenterMD5Notify(payConfig.Partner, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).Verify(sParaTemp, sign);
        }

        public string GetResponse(string des)
        {
            return "";
            //var response = new PayCenterResponse();
            //response.Partner = HttpContext.Current.Request["Partner"];
            //response.UserName = HttpContext.Current.Request["UserName"];
            //response.UserId = HttpContext.Current.Request["UserId"];
            //response.OrderNo = HttpContext.Current.Request["OrderNo"];
            //response.PayType = (PayEnum)Enum.Parse(typeof(PayEnum), HttpContext.Current.Request["PayType"], false);
            //response.PayRemark = HttpContext.Current.Request["PayRemark"];
            //response.TotalFee = Convert.ToDecimal(HttpContext.Current.Request["TotalFee"]);
            //response.SubmitTime = DateTime.Parse(HttpContext.Current.Request["SubmitTime"]);
            //response.sign = HttpContext.Current.Request["sign"];
            //response.sign_type = HttpContext.Current.Request["sign_type"];
            //response.IsSuccess = bool.Parse(HttpContext.Current.Request["IsSuccess"]);
            //return new ThirdPayResponse() { PayCenterResponse = response }; ;
        }
    }
}
