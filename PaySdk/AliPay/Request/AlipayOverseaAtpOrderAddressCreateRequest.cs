using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.oversea.atp.order.address.create
    /// </summary>
    public class AlipayOverseaAtpOrderAddressCreateRequest : IAopRequest<AlipayOverseaAtpOrderAddressCreateResponse>
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public string GmtModified { get; set; }

        /// <summary>
        /// 标志来源
        /// </summary>
        public string MarkFrom { get; set; }

        /// <summary>
        /// 支付宝绑定的手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 转运订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; set; }

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
            return "alipay.oversea.atp.order.address.create";
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
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("city", this.City);
            parameters.Add("email", this.Email);
            parameters.Add("gmt_create", this.GmtCreate);
            parameters.Add("gmt_modified", this.GmtModified);
            parameters.Add("mark_from", this.MarkFrom);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("province", this.Province);
            parameters.Add("user_id", this.UserId);
            parameters.Add("user_name", this.UserName);
            parameters.Add("zip_code", this.ZipCode);
            return parameters;
        }

        #endregion
    }
}
