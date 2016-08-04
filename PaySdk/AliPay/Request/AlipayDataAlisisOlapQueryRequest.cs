using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.alisis.olap.query
    /// </summary>
    public class AlipayDataAlisisOlapQueryRequest : IAopRequest<AlipayDataAlisisOlapQueryResponse>
    {
        /// <summary>
        /// 过滤条件
        /// </summary>
        public string FilterJson { get; set; }

        /// <summary>
        /// 度量过滤条件
        /// </summary>
        public string HavingFilterJson { get; set; }

        /// <summary>
        /// 工作表id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 最大值5000，返回结果集数量
        /// </summary>
        public Nullable<long> Limit { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string OrderJson { get; set; }

        /// <summary>
        /// 类型：cube/worksheet
        /// </summary>
        public string Type { get; set; }

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
            return "alipay.data.alisis.olap.query";
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
            parameters.Add("filter_json", this.FilterJson);
            parameters.Add("having_filter_json", this.HavingFilterJson);
            parameters.Add("id", this.Id);
            parameters.Add("limit", this.Limit);
            parameters.Add("order_json", this.OrderJson);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
