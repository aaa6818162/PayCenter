using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.recharge.order.update
    /// </summary>
    public class AlipayEbppRechargeOrderUpdateRequest : IAopRequest<AlipayEbppRechargeOrderUpdateResponse>
    {
        /// <summary>
        /// 对应状态的业务处理时间，格式：yyyyMMddHHmmss
        /// </summary>
        public string BizDate { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string MobileNo { get; set; }

        /// <summary>
        /// 淘宝交易订单号 payOrderId
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 状态  支付成功：P；充值成功：S；充值失败：F
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
            return "alipay.ebpp.recharge.order.update";
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
            parameters.Add("biz_date", this.BizDate);
            parameters.Add("mobile_no", this.MobileNo);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("status", this.Status);
            return parameters;
        }

        #endregion
    }
}
