using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using SyncSoft.PayCenterSdk.Config;
using SyncSoft.PayCenterSdk.Model;
using SyncSoft.PayCenterSdk.Request;
using SyncSoft.PayCenterSdk.Response;
using SyncSoft.PayCenterSdk.Tool;

namespace SyncSoft.PayCenterSdk.Service
{
    /// <summary>
    /// 支付中心
    /// </summary>
    public class PayCenterService : BasePayService, IPayService
    {
        #region Implementation of IPayService

        /// <summary>
        /// 建立请求 以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string BuildRequest(PayCenterRequest request, bool isRequest = true)
        {
            var payConfig = request.PartnerConfig.PayCenterConfig;
            //把请求参数打包成数组 
            var propertyList = request.GetType().GetProperties();
            var sParaTemp = new SortedDictionary<string, string>();
            propertyList.ToList().ForEach(p =>
            {
                if (p.GetValue(request, null) != null)
                {
                    if (p.Name != "PartnerConfig" && p.Name != "ThirdPayResponse")
                    {
                        sParaTemp.Add(p.Name, p.GetValue(request, null).ToString());
                    }
                }
            });

            //建立请求
            var sHtmlText = new PayCenterSubmit(isRequest ? payConfig.Gateway : payConfig.ReturnUrl, payConfig.Key).BuildRequest(sParaTemp, "post", "确认");
            log.LogInfo(new LogMessage());
            return sHtmlText;
        }

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string QueryOrderInfo(PayCenterRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="request"></param>
        /// <param name="sign"></param>
        /// <param name="isGet"></param>
        /// <returns></returns>
        public bool SignVerify(PayCenterRequest request, string sign, bool isGet = true)
        {
            var payConfig = request.PartnerConfig.PayCenterConfig;
            //把请求参数打包成数组 
            var propertyList = request.GetType().GetProperties();
            var sParaTemp = new SortedDictionary<string, string>();
            propertyList.ToList().ForEach(p =>
            {
                if (p.GetValue(request, null) != null)
                {
                    if (p.Name != "PartnerConfig" && p.Name != "ThirdPayResponse")
                    {
                        sParaTemp.Add(p.Name, p.GetValue(request, null).ToString());
                    }
                }
            });
            return new PayCenterNotify(payConfig.Partner, payConfig.Key).Verify(sParaTemp, sign);
        }

        /// <summary>
        /// 处理支付返回信息 通过上下文获取请求信息
        /// </summary>
        /// <param name="des">描述信息</param>
        /// <returns></returns>
        public ThirdPayResponse GetResponse(string des)
        {
            var response = new PayCenterResponse();
            response.Partner = HttpContext.Current.Request["Partner"];
            response.UserName = HttpContext.Current.Request["UserName"];
            response.UserId = HttpContext.Current.Request["UserId"];
            response.OrderNo = HttpContext.Current.Request["OrderNo"];
            response.PayType = (PayEnum)Enum.Parse(typeof(PayEnum), HttpContext.Current.Request["PayType"], false);
            response.PayRemark = HttpContext.Current.Request["PayRemark"];
            response.TotalFee = Convert.ToDecimal(HttpContext.Current.Request["TotalFee"]);
            response.SubmitTime = DateTime.Parse(HttpContext.Current.Request["SubmitTime"]);
            response.sign = HttpContext.Current.Request["sign"];
            response.sign_type = HttpContext.Current.Request["sign_type"];
            response.IsSuccess = bool.Parse(HttpContext.Current.Request["IsSuccess"]);
            return new ThirdPayResponse() { PayCenterResponse = response }; ;
        }

        #endregion
    }
}
