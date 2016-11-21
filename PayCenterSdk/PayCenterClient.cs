using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayCenterSdk.Model;
using PayCenterSdk.Tool;
using PayCenterSdk.Tool.Md5;

namespace PayCenterSdk
{
    /// <summary>
    /// 支付平台pc端
    /// </summary>
    public class PayCenterClient
    {
        /// <summary>
        /// 建立请求，以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetRequestHtml(PayCenterRequest request)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var propertyList = request.GetType().GetProperties();
            var sParaTemp = new SortedDictionary<string, string>();
            propertyList.ToList().ForEach(p =>
            {
                if (p.GetValue(request, null) != null)
                {
                    if (p.Name != "PayCenterConfig")
                    {
                        sParaTemp.Add(p.Name, p.GetValue(request, null).ToString());
                    }
                }
            });

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
        public string GetRequest(PayCenterRequest request)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var propertyList = request.GetType().GetProperties();
            var sParaTemp = new SortedDictionary<string, string>();
            propertyList.ToList().ForEach(p =>
            {
                if (p.GetValue(request, null) != null)
                {
                    if (p.Name != "PayCenterConfig")
                    {
                        sParaTemp.Add(p.Name, p.GetValue(request, null).ToString());
                    }
                }
            });

            //建立请求
            var result = new PayCenterMD5Submit(
                payConfig.Gateway, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).BuildRequest(sParaTemp);
            return result;
        }


        /// <summary>
        /// 签名认证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        public bool SignVerify(PayCenterResponse request, string sign)
        {
            var payConfig = request.PayCenterConfig;
            //把请求参数打包成数组 
            var propertyList = request.GetType().GetProperties();
            var sParaTemp = new SortedDictionary<string, string>();
            propertyList.ToList().ForEach(p =>
            {
                if (p.GetValue(request, null) != null)
                {
                    if (p.Name != "PayCenterConfig")
                    {
                        sParaTemp.Add(p.Name, p.GetValue(request, null).ToString());
                    }
                }
            });
            return new PayCenterMD5Notify(payConfig.Partner, payConfig.Md5Key, payConfig.InputCharset, payConfig.SignType).Verify(sParaTemp, sign);
        }

        /// <summary>
        /// 返回信息
        /// </summary>
        /// <returns></returns>
        public PayCenterResponse GePayCenterResponse()
        {
            var response = new PayCenterResponse();
            response.Partner = HttpContext.Current.Request["Partner"];
            response.OrderNo = HttpContext.Current.Request["OrderNo"];
            response.PayType = (PayEnum)PayEnum.Parse(typeof(PayEnum), HttpContext.Current.Request["PayType"]);
            response.ThridPaySerialNumber = HttpContext.Current.Request["ThridPaySerialNumber"];
            response.PayCenterSerialNumber = HttpContext.Current.Request["PayCenterSerialNumber"];
            response.PayTime = HttpContext.Current.Request["PayTime"];
            response.IsSuccess = bool.Parse(HttpContext.Current.Request["IsSuccess"]);
            return response;
        }


        public string GetPayCenterConfig(string partner, string gateway)
        {
            var sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("partner", partner);
            var result = new PayCenterMD5Submit(gateway).BuildRequest(sParaTemp);
            return "";
        }
    }
}
