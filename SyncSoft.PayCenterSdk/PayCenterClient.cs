using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.PayCenterSdk.Model;
using SyncSoft.PayCenterSdk.Request;
using SyncSoft.PayCenterSdk.Response;
using SyncSoft.PayCenterSdk.Service;
using SyncSoft.PayCenterSdk.Tool;

namespace SyncSoft.PayCenterSdk
{
    public class PayCenterClient
    {
        private readonly IPayService _payService;
        public PayCenterClient(PayEnum payEnum)
        {
            switch (payEnum)
            {
                case PayEnum.Alipay:
                    _payService = new AlipayService();
                    break;
                case PayEnum.CmbBank:
                    _payService = new CmbBankService();
                    break;
                default:
                    _payService = new PayCenterService();
                    break;
            }
        }

        #region Implementation of IPayCenterClient

        /// <summary>
        /// 提交表单HTML文本
        /// </summary>
        /// <returns></returns>
        public string GetRequestHtml(PayCenterRequest request, bool isRequest = true)
        {
            //建立请求
            return _payService.BuildRequest(request, isRequest);
        }

        /// <summary>
        /// 订单状态查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string QueryOrderInfo(PayCenterRequest request)
        {
            return _payService.QueryOrderInfo(request);
        }

        /// <summary>
        /// 处理结果
        /// </summary>
        /// <returns></returns>
        public ThirdPayResponse GetRequestResult(string des = "")
        {
            return _payService.GetResponse(des);
        }

        /// <summary>
        /// 签名验证
        /// </summary>
        /// <returns></returns>
        public bool SignVerify(PayCenterRequest request, string sign)
        {
            return _payService.SignVerify(request, sign);
        }

        #endregion
    }
}
