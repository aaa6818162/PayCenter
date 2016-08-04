using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.fund.transfer.batch.createorder
    /// </summary>
    public class AlipayFundTransferBatchCreateorderRequest : IAopRequest<AlipayFundTransferBatchCreateorderResponse>
    {
        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        public string ExtParam { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 收款方userId
        /// </summary>
        public string PayeeId { get; set; }

        /// <summary>
        /// 付款方userId
        /// </summary>
        public string PayerId { get; set; }

        /// <summary>
        /// token
        /// </summary>
        public string Token { get; set; }

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
            return "alipay.fund.transfer.batch.createorder";
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
            parameters.Add("batch_no", this.BatchNo);
            parameters.Add("ext_param", this.ExtParam);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("payee_id", this.PayeeId);
            parameters.Add("payer_id", this.PayerId);
            parameters.Add("token", this.Token);
            return parameters;
        }

        #endregion
    }
}
