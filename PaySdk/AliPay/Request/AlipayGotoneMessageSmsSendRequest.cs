using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.gotone.message.sms.send
    /// </summary>
    public class AlipayGotoneMessageSmsSendRequest : IAopRequest<AlipayGotoneMessageSmsSendResponse>
    {
        /// <summary>
        /// 模板参数
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// 接收短信手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 短信模板对应的serviceCode
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 用户的支付宝ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.gotone.message.sms.send";
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
            parameters.Add("arguments", this.Arguments);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("service_code", this.ServiceCode);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
