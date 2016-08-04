using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.recharge.saleproduct.get
    /// </summary>
    public class AlipayEbppRechargeSaleproductGetRequest : IAopRequest<AlipayEbppRechargeSaleproductGetResponse>
    {
        /// <summary>
        /// 来源,例如：主站,淘宝,客户端
        /// </summary>
        public string Agent { get; set; }

        /// <summary>
        /// 必须以key value形式定义，转为json为格式：{"key1":"value1","key2":"value2","key3":"value3","key4":"value4"}   后端会直接转换为MAP对象，转换异常会报参数格式错误
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNo { get; set; }

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
            return "alipay.ebpp.recharge.saleproduct.get";
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
            parameters.Add("agent", this.Agent);
            parameters.Add("extend_field", this.ExtendField);
            parameters.Add("mobile_no", this.MobileNo);
            return parameters;
        }

        #endregion
    }
}
