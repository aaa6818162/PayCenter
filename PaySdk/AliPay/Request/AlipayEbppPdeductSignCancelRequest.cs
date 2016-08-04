using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.sign.cancel
    /// </summary>
    public class AlipayEbppPdeductSignCancelRequest : IAopRequest<AlipayEbppPdeductSignCancelResponse>
    {
        /// <summary>
        /// 操作来源  PUBLICPLATFORM：服务窗
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 标识发起方的ID，从服务窗发起则为publicId的值
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 通过调起极简客户端进行支付密码验证获得的token
        /// </summary>
        public string PayPasswordToken { get; set; }

        /// <summary>
        /// 通过服务窗拿到的openId（即加密后的userID）
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
            return "alipay.ebpp.pdeduct.sign.cancel";
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
            parameters.Add("agent_channel", this.AgentChannel);
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("pay_password_token", this.PayPasswordToken);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
