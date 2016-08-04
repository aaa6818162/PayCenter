using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.subscribe.upload
    /// </summary>
    public class AlipayEbppSubscribeUploadRequest : IAopUploadRequest<AlipayEbppSubscribeUploadResponse>
    {
        /// <summary>
        /// 出账机构简称，例如杭州水务HZWATER
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 业务类型，例如缴费JF
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 子业务类型，例如电费ELECTRIC
        /// </summary>
        public string SubOrderType { get; set; }

        /// <summary>
        /// 回盘文件中的内容格式，例如9023|UN_SUBSCRIBE 为户号为9023，订阅状态为UN_SUBSCRIBE
        /// </summary>
        public FileItem SubscribeDetail { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.ebpp.subscribe.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("sub_order_type", this.SubOrderType);
            return parameters;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("subscribe_detail", this.SubscribeDetail);
            return parameters;
        }

        #endregion
    }
}
