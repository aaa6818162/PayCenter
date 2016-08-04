using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.sync.send
    /// </summary>
    public class AlipayPassSyncSendRequest : IAopRequest<AlipayPassSyncSendResponse>
    {
        /// <summary>
        /// alipass文件Base64加密后的字符串
        /// </summary>
        public string FileContent { get; set; }

        /// <summary>
        /// 支付宝交易外部订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// alipass核销区域核销方式
        /// </summary>
        public string VerifyType { get; set; }

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
            return "alipay.pass.sync.send";
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
            parameters.Add("file_content", this.FileContent);
            parameters.Add("out_trade_no", this.OutTradeNo);
            parameters.Add("partner_id", this.PartnerId);
            parameters.Add("verify_type", this.VerifyType);
            return parameters;
        }

        #endregion
    }
}
