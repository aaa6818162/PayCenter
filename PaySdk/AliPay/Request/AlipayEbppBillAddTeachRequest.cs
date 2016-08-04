using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.bill.add.teach
    /// </summary>
    public class AlipayEbppBillAddTeachRequest : IAopRequest<AlipayEbppBillAddTeachResponse>
    {
        /// <summary>
        /// bank_bill_no
        /// </summary>
        public string BankBillNo { get; set; }

        /// <summary>
        /// 201203
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 3388102012376451
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// BJCEB
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// extend_field
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 出机构的业务流水号，需要保证唯一性
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 15987838584
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// owner_name
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 23.45
        /// </summary>
        public List<string> PayAmount { get; set; }

        /// <summary>
        /// 8
        /// </summary>
        public string ServiceAmount { get; set; }

        /// <summary>
        /// eee
        /// </summary>
        public string SubOrderType { get; set; }

        /// <summary>
        /// 浙江,杭徽高速
        /// </summary>
        public string TrafficLocation { get; set; }

        /// <summary>
        /// traffic_regulations
        /// </summary>
        public string TrafficRegulations { get; set; }

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
            return "alipay.ebpp.bill.add.teach";
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
            parameters.Add("bank_bill_no", this.BankBillNo);
            parameters.Add("bill_date", this.BillDate);
            parameters.Add("bill_key", this.BillKey);
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("extend_field", this.ExtendField);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("owner_name", this.OwnerName);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("service_amount", this.ServiceAmount);
            parameters.Add("sub_order_type", this.SubOrderType);
            parameters.Add("traffic_location", this.TrafficLocation);
            parameters.Add("traffic_regulations", this.TrafficRegulations);
            return parameters;
        }

        #endregion
    }
}
