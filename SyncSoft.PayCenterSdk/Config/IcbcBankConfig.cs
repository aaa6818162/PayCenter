using System;

namespace SyncSoft.PayCenterSdk.Config
{
    /// <summary>
    /// 工商银行支付实体交易
    /// 日期时间yyyyMMddHHmmss
    /// </summary>
    [Serializable]
    public class IcbcBankConfig
    {
        public IcbcBankConfig()
        {
            InterfaceName = "ICBC_PERBANK_B2C";
            InterfaceVersion = "1.0.0.11";
            InstallmentTimes = "1";
            GoodsName = "Harborhouse";
            VerifyJoinFlag = "0";
            Language = "ZH_CN";
            CurType = "001";
            CreditType = "2";
            NotifyType = "HS";
            ResultType = "1";
            MerOrderRemark = "Harborhouse";   
        }
        /// <summary>
        /// 接口名称
        /// </summary>
        public string InterfaceName { get; set; }
        /// <summary>
        /// 接口版本号
        /// </summary>
        public string InterfaceVersion { get; set; }
        /// <summary>
        /// 分期付款期数 必输，每笔订单一个；
        /// 取值：1、3、6、9、12、18、24；1代表全额付款，必须为以上数值，否则订单校验不通过。
        /// </summary>
        public string InstallmentTimes { get; set; }
        /// <summary>
        /// 网关地址
        /// </summary>
        public string IcbcGateway { get; set; }
        /// <summary>
        /// 交易数据
        /// </summary>
        public string TranData { get; set; }
        /// <summary>
        /// 订单签名数据
        /// </summary>
        public string MerSignMsg { get; set; }
        /// <summary>
        /// 商城证书公钥
        /// </summary>
        public string MerCert { get; set; }
        /// <summary>
        /// 交易数据,Xml明文
        /// </summary>
        public string TranDataXml { get; set; }
        /// <summary>
        /// 商户账号
        /// </summary>
        public string MerAcct { get; set; }
        /// <summary>
        /// 商品编号 选输
        /// </summary>
        public string GoodsId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品数量 选输
        /// </summary>
        public string GoodsNum { get; set; }
        /// <summary>
        /// 已含运费金额 选输
        /// </summary>
        public string CarriageAmt { get; set; }
        /// <summary>
        /// 检验联名标志,取值“1”
        /// </summary>
        public string VerifyJoinFlag { get; set; }
        /// <summary>
        /// 语言版本选输，默认为中文版
        /// 取值：“EN_US”为英文版；
        /// 取值：“ZH_CN”或其他为中文版。
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        ///  支付币种 人民币（001）
        /// </summary>
        public string CurType { get; set; }
        /// <summary>
        /// 商户代码
        /// </summary>
        public string MerId { get; set; }
        /// <summary>
        /// 支持订单支付的银行卡种类默认“2”。取值范围为0、1、2，
        /// 其中0表示仅允许使用借记卡支付，1表示仅允许使用信用卡支付，
        /// 2表示借记卡和信用卡都能对订单进行支付
        /// </summary>
        public string CreditType { get; set; }
        /// <summary>
        /// 通知类型在交易转账处理完成后把交易结果通知商户的处理模式。
        /// 取值“HS”：在交易完成后实时将通知信息以HTTP协议POST方式，主动发送给商户，发送地址为商户端随订单数据提交的接收工行支付结果的URL即表单中的merURL字段；
        /// 取值“AG”：在交易完成后不通知商户。商户需使用浏览器登录工行的B2C商户服务网站，或者使用工行提供的客户端程序API主动获取通知信息。
        /// </summary>
        public string NotifyType { get; set; }
        /// <summary>
        /// 结果发送类型取值“0”：无论支付成功或者失败，银行都向商户发送交易通知信息；
        /// 取值“1”，银行只向商户发送交易成功的通知信息。
        /// 只有通知方式为HS时此值有效，如果使用AG方式，可不上送此项，但签名数据中必须包含此项，取值可为空。
        /// </summary>
        public string ResultType { get; set; }
        /// <summary>
        /// 商户reference商户网站域名
        /// </summary>
        public string MerReference { get; set; }
        /// <summary>
        /// 客户端IP
        /// </summary>
        public string MerCustomIp { get; set; }
        /// <summary>
        /// 虚拟商品/实物商品标志位
        /// 取值“0”：虚拟商品；
        /// 取值“1”，实物商品。
        /// </summary>
        public string GoodsType { get; set; }
        /// <summary>
        /// 买家用户号
        /// </summary>
        public string MerCustomId { get; set; }
        /// <summary>
        /// 买家联系电话
        /// </summary>
        public string MerCustomPhone { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string GoodsAddress { get; set; }
        /// <summary>
        /// 订单备注
        /// </summary>
        public string MerOrderRemark { get; set; }
        /// <summary>
        /// 商城提示
        /// </summary>
        public string MerHint { get; set; }
        /// <summary>
        /// 备注字段1
        /// </summary>
        public string Remark1 { get; set; }
        /// <summary>
        /// 备注字段2
        /// </summary>
        public string Remark2 { get; set; }
        /// <summary>
        /// 返回商户URL
        /// </summary>
        public string MerUrl { get; set; }
        /// <summary>
        /// 返回商户变量
        /// </summary>
        public string MerVar { get; set; }

    }
}
