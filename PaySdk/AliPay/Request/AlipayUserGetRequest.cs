using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.get
    /// </summary>
    public class AlipayUserGetRequest : IAopRequest<AlipayUserGetResponse>
    {
        /// <summary>
        /// 12
        /// </summary>
        public string ASY { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        public string Ddd { get; set; }

        /// <summary>
        /// 需要返回的字段列表。alipay_user_id：支付宝用户userId,user_status：支付宝用户状态,user_type：支付宝用户类型,certified：是否通过实名认证,real_name：真实姓名,logon_id：支付宝登录号,sex：用户性别
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        public string SsEee { get; set; }

        /// <summary>
        /// a s da s d
        /// </summary>
        public string YyDsss { get; set; }

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
            return "alipay.user.get";
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
            parameters.Add("a_s_y", this.ASY);
            parameters.Add("ddd", this.Ddd);
            parameters.Add("fields", this.Fields);
            parameters.Add("ss_eee", this.SsEee);
            parameters.Add("yy_dsss", this.YyDsss);
            return parameters;
        }

        #endregion
    }
}
