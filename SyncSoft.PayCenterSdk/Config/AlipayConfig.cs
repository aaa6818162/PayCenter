namespace SyncSoft.PayCenterSdk.Config
{
    /// <summary>
    /// 支付宝支付实体
    /// </summary>
    public class AlipayConfig
    {

        /// <summary>
        /// 合作身份者ID
        /// </summary>
        public string Partner { get; set; }


        /// <summary>
        /// 支付宝网关 https://mapi.alipay.com/gateway.do?
        /// </summary>
        public string Gateway
        {
            get { return "https://mapi.alipay.com/gateway.do?"; }
        }

 
        /// <summary>
        /// 消息验证地址 (支付回调信息)
        /// </summary>
        public string HttpsVeryfyUrl
        {
               get { return "https://mapi.alipay.com/gateway.do?service=notify_verify&"; }
        }

        /// <summary>
        /// 交易安全检验码
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 服务器异步通知页面路径
        /// </summary>
        public string NotifyUrl { get; set; }
        /// <summary>
        /// 页面跳转同步通知页面路径
        /// </summary>
        public string ReturnUrl { get; set; }
        /// <summary>
        /// 卖家支付宝帐户
        /// </summary>
        public string SellerEmail { get; set; }
        /// <summary>
        /// 支付备注信息
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 字符编码格式 目前支持 gbk 或 utf-8
        /// </summary>
        public string InputCharset
        {
            get { return "utf-8"; }
        }

        /// <summary>
        /// 签名方式，选择项：RSA、DSA、MD5
        /// </summary>
        public string SignType
        {
            get { return "MD5"; }
        }


    }
}
