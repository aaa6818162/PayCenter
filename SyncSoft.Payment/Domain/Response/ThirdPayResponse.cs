using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncSoft.Payment.Domain.Response
{
    /// <summary>
    /// 第三方支付返回的信息
    /// </summary>
    public class ThirdPayResponse
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 第三方支付流水号
        /// </summary>
        public string ThridPaySerialNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        public string PayTime { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        public string ErrorMsg { get; set; }

        /// <summary>
        /// 其他扩展参数
        /// </summary>
        public SortedDictionary<string, string> OtherParameters { get; set; }

    }
}
