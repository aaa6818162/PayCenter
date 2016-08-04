using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayCenterSdk.Model;

namespace PayCenterSdk
{
    public class PayCenterResponse 
    {
        /// <summary>
        /// 支付平台商户号
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 选择的支付类型
        /// </summary>
        public PayEnum PayType { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        public string ThridPaySerialNumber { get; set; }

        /// <summary>
        /// 支付平台流水号
        /// </summary>
        public string PayCenterSerialNumber { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        public string PayTime { get; set; }

        /// <summary>
        /// 支付是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 支付中心
        /// </summary>
        public PayCenterConfig PayCenterConfig { get; set; }
    }
}
