using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.overseas.acquire.customs.query.depre
    /// </summary>
    public class AlipayOverseasAcquireCustomsQueryDepreRequest : IAopRequest<AlipayOverseasAcquireCustomsQueryDepreResponse>
    {
        /// <summary>
        /// 在与海关系统的对接中，支付单推送失败或支付单在海关系统中丢失的情况时常发生。原因可能是海关系统的不稳定、商户信息填写错误、支付单或订单格式不符合海关新增的校验逻辑等等。商户从海关处得到“支付信息不存在”的反馈后，请求支付宝技术支持查询支付单推送状态、重推支付单、或者修改备案号、备案名称或者需要推送的海关并且重推。占用技术支持大量时间，也降低了商户处理的效率。需要提供一个查询推送状态的接口，使商户能
        /// </summary>
        public string BizContent { get; set; }

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
            return "alipay.overseas.acquire.customs.query.depre";
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
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
