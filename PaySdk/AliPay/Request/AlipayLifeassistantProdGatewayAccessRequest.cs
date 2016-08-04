using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.lifeassistant.prod.gateway.access
    /// </summary>
    public class AlipayLifeassistantProdGatewayAccessRequest : IAopRequest<AlipayLifeassistantProdGatewayAccessResponse>
    {
        /// <summary>
        /// 业务类型  1-手机充值  2-公共事业缴费  3-信用卡还款
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// json格式字符串
        /// </summary>
        public string ExtParams { get; set; }

        /// <summary>
        /// 商户类型  10001-新浪微博
        /// </summary>
        public string MType { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        public string Uid { get; set; }

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
            return "alipay.lifeassistant.prod.gateway.access";
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
            parameters.Add("biz_type", this.BizType);
            parameters.Add("ext_params", this.ExtParams);
            parameters.Add("m_type", this.MType);
            parameters.Add("uid", this.Uid);
            return parameters;
        }

        #endregion
    }
}
