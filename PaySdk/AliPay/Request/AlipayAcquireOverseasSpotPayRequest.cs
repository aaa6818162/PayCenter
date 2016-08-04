using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.acquire.overseas.spot.pay
    /// </summary>
    public class AlipayAcquireOverseasSpotPayRequest : IAopRequest<AlipayAcquireOverseasSpotPayResponse>
    {
        /// <summary>
        /// Used as identification of a Alipay user.  The format of the Buyer_identity_code varies depending on the identity_code_type
        /// </summary>
        public string BuyerIdentityCode { get; set; }

        /// <summary>
        /// The currency used for labeling the price of the transaction;Refer to the acronym of currency table
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Containing the extended parameters of the request, it’s in JSON format.    For now it contains the following parameters：  merchant_name;  merchant_no;  business_no;  terminal_id;  mcc;  region_code
        /// </summary>
        public string ExtendInfo { get; set; }

        /// <summary>
        /// he identity code type could be qrcode, barcode or soundwave;    only barcode is supported for now
        /// </summary>
        public string IdentityCodeType { get; set; }

        /// <summary>
        /// Transaction notes
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// The transaction Id on the partner system which could be a sale order id and payment order id.   Alipay system uses the partner_trans_id and the partner to identity a transaction on partner side
        /// </summary>
        public string PartnerTransId { get; set; }

        /// <summary>
        /// There are three kinds of password: login password, payment password and mobile password.  In the barcode payment scenario, the mobile password is used;    3DES is used for encryption/ decryption.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the transaction amount in the currency given above;  Range: 0.01-100000000.00. Two digits after decimal point
        /// </summary>
        public string TransAmount { get; set; }

        /// <summary>
        /// The name of the transaction which will be shown in the transaction records list
        /// </summary>
        public string TransName { get; set; }

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
            return "alipay.acquire.overseas.spot.pay";
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
            parameters.Add("buyer_identity_code", this.BuyerIdentityCode);
            parameters.Add("currency", this.Currency);
            parameters.Add("extend_info", this.ExtendInfo);
            parameters.Add("identity_code_type", this.IdentityCodeType);
            parameters.Add("memo", this.Memo);
            parameters.Add("partner_trans_id", this.PartnerTransId);
            parameters.Add("password", this.Password);
            parameters.Add("trans_amount", this.TransAmount);
            parameters.Add("trans_name", this.TransName);
            return parameters;
        }

        #endregion
    }
}
