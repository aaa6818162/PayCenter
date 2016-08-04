using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.fund.transfer.batch.createbatch
    /// </summary>
    public class AlipayFundTransferBatchCreatebatchRequest : IAopRequest<AlipayFundTransferBatchCreatebatchResponse>
    {
        /// <summary>
        /// batch_memo
        /// </summary>
        public string BatchMemo { get; set; }

        /// <summary>
        /// 总金额，单位为元：         AA为收款总金额              活动收款为份数和单笔金额的积              江湖救急为目标金额
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        public string CreateUserId { get; set; }

        /// <summary>
        /// ext_param
        /// </summary>
        public string ExtParam { get; set; }

        /// <summary>
        /// pay_amount_single
        /// </summary>
        public string PayAmountSingle { get; set; }

        /// <summary>
        /// pay_amount_total
        /// </summary>
        public string PayAmountTotal { get; set; }

        /// <summary>
        /// real_items_total
        /// </summary>
        public string RealItemsTotal { get; set; }

        /// <summary>
        /// show_items_total
        /// </summary>
        public string ShowItemsTotal { get; set; }

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
            return "alipay.fund.transfer.batch.createbatch";
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
            parameters.Add("batch_memo", this.BatchMemo);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("create_user_id", this.CreateUserId);
            parameters.Add("ext_param", this.ExtParam);
            parameters.Add("pay_amount_single", this.PayAmountSingle);
            parameters.Add("pay_amount_total", this.PayAmountTotal);
            parameters.Add("real_items_total", this.RealItemsTotal);
            parameters.Add("show_items_total", this.ShowItemsTotal);
            return parameters;
        }

        #endregion
    }
}
