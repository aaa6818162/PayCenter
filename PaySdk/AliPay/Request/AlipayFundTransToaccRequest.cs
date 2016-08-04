using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.fund.trans.toacc
    /// </summary>
    public class AlipayFundTransToaccRequest : IAopRequest<AlipayFundTransToaccResponse>
    {
        /// <summary>
        /// 转账金额
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 扩展参数，json字符串格式
        /// </summary>
        public string ExtParam { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 商户转账唯一订单号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方账户
        /// </summary>
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款方真实姓名
        /// </summary>
        public string PayeeRealName { get; set; }

        /// <summary>
        /// 收款方显示姓名
        /// </summary>
        public string PayeeShowName { get; set; }

        /// <summary>
        /// 收款方账户类型
        /// </summary>
        public string PayeeType { get; set; }

        /// <summary>
        /// 付款方账户
        /// </summary>
        public string PayerAccount { get; set; }

        /// <summary>
        /// 付款方真实姓名
        /// </summary>
        public string PayerRealName { get; set; }

        /// <summary>
        /// 付款方显示姓名
        /// </summary>
        public string PayerShowName { get; set; }

        /// <summary>
        /// 付款方账户类型
        /// </summary>
        public string PayerType { get; set; }

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
            return "alipay.fund.trans.toacc";
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
            parameters.Add("amount", this.Amount);
            parameters.Add("ext_param", this.ExtParam);
            parameters.Add("memo", this.Memo);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("payee_account", this.PayeeAccount);
            parameters.Add("payee_real_name", this.PayeeRealName);
            parameters.Add("payee_show_name", this.PayeeShowName);
            parameters.Add("payee_type", this.PayeeType);
            parameters.Add("payer_account", this.PayerAccount);
            parameters.Add("payer_real_name", this.PayerRealName);
            parameters.Add("payer_show_name", this.PayerShowName);
            parameters.Add("payer_type", this.PayerType);
            return parameters;
        }

        #endregion
    }
}
