using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncSoft.Payment.Domain.Response
{
    /// <summary>
    /// 支付宝返回信息
    /// </summary>
    public class AlipayResponse
    {


        public string body { get; set; }
        public string buyer_email { get; set; }
        public string buyer_id { get; set; }
        public string exterface { get; set; }
        public string is_success { get; set; }
        public string notify_id { get; set; }
        public string notify_time { get; set; }
        public string notify_type { get; set; }
        public string out_trade_no { get; set; }
        public string payment_type { get; set; }
        public string seller_email { get; set; }
        public string seller_id { get; set; }
        public string subject { get; set; }
        public string total_fee { get; set; }
        public string trade_no { get; set; }
        public string trade_status { get; set; }
        public string sign { get; set; }
        public string sign_type { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                if (trade_status == "WAIT_SELLER_SEND_GOODS" || trade_status == "TRADE_FINISHED" ||
                       trade_status == "TRADE_SUCCESS")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
