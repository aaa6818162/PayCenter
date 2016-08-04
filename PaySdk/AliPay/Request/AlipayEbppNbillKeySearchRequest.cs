using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.nbill.key.search
    /// </summary>
    public class AlipayEbppNbillKeySearchRequest : IAopRequest<AlipayEbppNbillKeySearchResponse>
    {
        /// <summary>
        /// 取消纸质账单枚举code
        /// </summary>
        public string CancelpaperCode { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 结束时间：格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 返回户号集合
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 该属性已废弃使用，删除不了属性，也修改不了。
        /// </summary>
        public Nullable<bool> IsCancelpaper { get; set; }

        /// <summary>
        /// 该属性已废弃使用，删除不了属性，也修改不了。
        /// </summary>
        public Nullable<bool> IsSubscribed { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK     1
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 查询纸质账单结束时间
        /// </summary>
        public string PendTime { get; set; }

        /// <summary>
        /// 纸质账单取消开始时间：格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string PstartTime { get; set; }

        /// <summary>
        /// 开始时间，时间必须是今天范围之内。格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费
        /// </summary>
        public string SubOrderType { get; set; }

        /// <summary>
        /// 订阅状态枚举code
        /// </summary>
        public string SubscribedCode { get; set; }

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
            return "alipay.ebpp.nbill.key.search";
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
            parameters.Add("cancelpaper_code", this.CancelpaperCode);
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("is_cancelpaper", this.IsCancelpaper);
            parameters.Add("is_subscribed", this.IsSubscribed);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("pend_time", this.PendTime);
            parameters.Add("pstart_time", this.PstartTime);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("sub_order_type", this.SubOrderType);
            parameters.Add("subscribed_code", this.SubscribedCode);
            return parameters;
        }

        #endregion
    }
}
