using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.Payment.Config;
using SyncSoft.Payment.Model;
using SyncSoft.Payment.Model.Config;

namespace SyncSoft.Payment.Domain.Request
{
    public class GetRequestHtmlRequest
    {
        public GetRequestHtmlRequest()
        {
            PartnerPayConfig=new PartnerPayConfig();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <summary>
        /// 第三方商户号
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// 支付平台商户号
        /// </summary>
        public string PayCenterPartner { get; set; }

        /// <summary>
        /// 登录账号名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 登录账号Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付备注信息
        /// </summary>
        public string PayRemark { get; set; }

        /// <summary>
        /// 订单合计
        /// </summary>
        public decimal TotalFee { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime SubmitTime { get; set; }


        public Tuple<bool, string> Validate()
        {
            var msg = "当前交易请求缺少必要的参数";
            if (string.IsNullOrEmpty(Partner))
            {
                msg += "Partner";
                return new Tuple<bool, string>(true, msg);
            }
            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 
        /// </summary>
        public PartnerPayConfig PartnerPayConfig { get; set; }

    }
}
