using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.promorulecenter.rule.analyze
    /// </summary>
    public class AlipayPromorulecenterRuleAnalyzeRequest : IAopRequest<AlipayPromorulecenterRuleAnalyzeResponse>
    {
        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        public string RuleUuid { get; set; }

        /// <summary>
        /// 支付宝用户id
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
            return "alipay.promorulecenter.rule.analyze";
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
            parameters.Add("biz_id", this.BizId);
            parameters.Add("rule_uuid", this.RuleUuid);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
