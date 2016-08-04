using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.address.add
    /// </summary>
    public class AlipayUserAddressAddRequest : IAopRequest<AlipayUserAddressAddResponse>
    {
        /// <summary>
        /// 收获详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 所在区的名称
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 数据来源：海外
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string Prov { get; set; }

        /// <summary>
        /// 用户UID
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
            return "alipay.user.address.add";
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
            parameters.Add("address", this.Address);
            parameters.Add("area", this.Area);
            parameters.Add("city", this.City);
            parameters.Add("from", this.From);
            parameters.Add("post", this.Post);
            parameters.Add("prov", this.Prov);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
