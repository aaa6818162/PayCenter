using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.movie.activity.notify
    /// </summary>
    public class AlipayMobileMovieActivityNotifyRequest : IAopRequest<AlipayMobileMovieActivityNotifyResponse>
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        public string ActivityDetail { get; set; }

        /// <summary>
        /// 淘宝活动id
        /// </summary>
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动状态：1(正常)；2(暂停);3(预发)
        /// </summary>
        public string Status { get; set; }

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
            return "alipay.mobile.movie.activity.notify";
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
            parameters.Add("activity_detail", this.ActivityDetail);
            parameters.Add("activity_id", this.ActivityId);
            parameters.Add("status", this.Status);
            return parameters;
        }

        #endregion
    }
}
