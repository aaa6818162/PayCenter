using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.alisis.authority.grant
    /// </summary>
    public class AlipayDataAlisisAuthorityGrantRequest : IAopRequest<AlipayDataAlisisAuthorityGrantResponse>
    {
        /// <summary>
        /// 过期日期yyyy-MM-dd
        /// </summary>
        public string ExpireTime { get; set; }

        /// <summary>
        /// 仪表盘的id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// id的类型：仪表盘worksheet
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 工号
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
            return "alipay.data.alisis.authority.grant";
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
            parameters.Add("expire_time", this.ExpireTime);
            parameters.Add("id", this.Id);
            parameters.Add("type", this.Type);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
