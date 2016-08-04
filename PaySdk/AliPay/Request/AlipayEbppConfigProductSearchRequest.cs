using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.config.product.search
    /// </summary>
    public class AlipayEbppConfigProductSearchRequest : IAopRequest<AlipayEbppConfigProductSearchResponse>
    {
        /// <summary>
        /// 出账机构例如杭州电力HZELECTRIC
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 获取场景，如query或者是confirm
        /// </summary>
        public string FieldScene { get; set; }

        /// <summary>
        /// 产品业务类型如缴费：JF
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 产品子业务类型如水费WATER
        /// </summary>
        public string SubOrderType { get; set; }

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
            return "alipay.ebpp.config.product.search";
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
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("field_scene", this.FieldScene);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("sub_order_type", this.SubOrderType);
            return parameters;
        }

        #endregion
    }
}
