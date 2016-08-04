using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.promo.event.send
    /// </summary>
    public class AlipayPromoEventSendRequest : IAopRequest<AlipayPromoEventSendResponse>
    {
        /// <summary>
        /// 动作子类型，二级动作
        /// </summary>
        public string ActionSubType { get; set; }

        /// <summary>
        /// 同步的动作
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// 扩展字段,以逗号分隔的属性列表如bizOrderNo,number,nick
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 商户当前用户登录名
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 设备类型如：pc,phone,pad,other
        /// </summary>
        public string TermType { get; set; }

        /// <summary>
        /// 创建时间，动作发生的时间，
        /// </summary>
        public Nullable<DateTime> Time { get; set; }

        /// <summary>
        /// 支付宝的userId
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
            return "alipay.promo.event.send";
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
            parameters.Add("action_sub_type", this.ActionSubType);
            parameters.Add("action_type", this.ActionType);
            parameters.Add("ext", this.Ext);
            parameters.Add("login_id", this.LoginId);
            parameters.Add("term_type", this.TermType);
            parameters.Add("time", this.Time);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
