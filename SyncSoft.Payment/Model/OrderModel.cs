using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncSoft.Payment.Model
{
    public class OrderModel
    { /// <summary>
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

        /// <summary>
        /// 字符编码格式 目前支持 gbk 或 utf-8
        /// </summary>
        public string InputCharset { get; set; }

    }
}
