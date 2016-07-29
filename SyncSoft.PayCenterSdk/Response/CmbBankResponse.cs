namespace SyncSoft.PayCenterSdk.Response
{
    /// <summary>
    /// 招商银行
    /// </summary>
    public class CmbBankResponse
    {
        /// <summary>
        /// 取值Y(成功)或N(失败)；
        /// </summary>
        public string Succeed { get; set; }
       
        /// <summary>
        /// 定单号(由支付命令送来)
        /// </summary>  
        public string BillNo { get; set; }

        /// <summary>
        /// 实际支付金额(由支付命令送来)；
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 交易日期(主机交易日期)；
        /// </summary>
        public string Date { get; set; }
       
        /// <summary>
        /// 银行通知用户的支付结果消息。信息的前38个字符格式为：4位分行号＋6位商户号＋8位银行接受交易的日期＋20位银行流水号；可以利用交易日期＋银行流水号对该定单进行结帐处理；
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 银行用自己的Private Key对通知命令的签名。
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// url参数串
        /// </summary>
        public string UrlParamtersStr { get; set; }

    }
}
