using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.transfer.bank.pay.apply
    /// </summary>
    public class AlipayTransferBankPayApplyRequest : IAopRequest<AlipayTransferBankPayApplyResponse>
    {
        /// <summary>
        /// 支付宝账户类型对应的id。如email、手机等
        /// </summary>
        public string AlipayAccountId { get; set; }

        /// <summary>
        /// 支付宝账户类型  ALIPAY_LOGON_ID:支付宝账户登录名  ALIPAY_USER_ID:支付宝账户userId
        /// </summary>
        public string AlipayAccountType { get; set; }

        /// <summary>
        /// 金额（单位为分）
        /// </summary>
        public Nullable<long> Amount { get; set; }

        /// <summary>
        /// 银行订单号
        /// </summary>
        public string BankOrderNo { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 业务类型(DY：为本人充值，DO:为他人充值)
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 转账备注信息,暂不支持对外显示
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 付款方卡账户类型  CP对公  PI:对私
        /// </summary>
        public string PayerCardAccountType { get; set; }

        /// <summary>
        /// 机构用户卡id标示，填写卡id类型对应的值。如email、手机等
        /// </summary>
        public string PayerCardId { get; set; }

        /// <summary>
        /// 付款方卡id标示类型  BANK_ID：银行用户uid  BANK_CARD_NO:银行卡号
        /// </summary>
        public string PayerCardIdType { get; set; }

        /// <summary>
        /// 付款方卡类型  DC:借记卡  CC:贷记卡
        /// </summary>
        public string PayerCardType { get; set; }

        /// <summary>
        /// 付款方机构编号，由支付宝定义
        /// </summary>
        public string PayerInstId { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;


		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.transfer.bank.pay.apply";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_account_id", this.AlipayAccountId);
            parameters.Add("alipay_account_type", this.AlipayAccountType);
            parameters.Add("amount", this.Amount);
            parameters.Add("bank_order_no", this.BankOrderNo);
            parameters.Add("biz_order_no", this.BizOrderNo);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("memo", this.Memo);
            parameters.Add("payer_card_account_type", this.PayerCardAccountType);
            parameters.Add("payer_card_id", this.PayerCardId);
            parameters.Add("payer_card_id_type", this.PayerCardIdType);
            parameters.Add("payer_card_type", this.PayerCardType);
            parameters.Add("payer_inst_id", this.PayerInstId);
            return parameters;
        }

        #endregion
    }
}
