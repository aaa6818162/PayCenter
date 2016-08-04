using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.risk.search
    /// </summary>
    public class AlipayTrustUserRiskSearchRequest : IAopRequest<AlipayTrustUserRiskSearchResponse>
    {
        /// <summary>
        /// 是否获得被查用户授权标识
        /// </summary>
        public Nullable<bool> Authorized { get; set; }

        /// <summary>
        /// (完整身份证号+完整姓名)的md5值
        /// </summary>
        public string IdCardNameMd5 { get; set; }

        /// <summary>
        /// 用户的完整姓名
        /// </summary>
        public string Name { get; set; }

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
            return "alipay.trust.user.risk.search";
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
            parameters.Add("authorized", this.Authorized);
            parameters.Add("id_card_name_md5", this.IdCardNameMd5);
            parameters.Add("name", this.Name);
            return parameters;
        }

        #endregion
    }
}
