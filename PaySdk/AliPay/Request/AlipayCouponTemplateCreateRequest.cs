using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.coupon.template.create
    /// </summary>
    public class AlipayCouponTemplateCreateRequest : IAopRequest<AlipayCouponTemplateCreateResponse>
    {
        /// <summary>
        /// 红包使用地址
        /// </summary>
        public string ActiveUrl { get; set; }

        /// <summary>
        /// 平均红包面额（单位为元）
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        public string CouponName { get; set; }

        /// <summary>
        /// 红包发放总金额（保证金总额，单位为元）
        /// </summary>
        public string CustGuaranteeAmount { get; set; }

        /// <summary>
        /// 领用规则ID（线下提前沟通）
        /// </summary>
        public string DrawBizRuleId { get; set; }

        /// <summary>
        /// 红包使用开始时间（绝对时间指定具体日期时间，相对时间为数字天数）
        /// </summary>
        public string GmtCouActive { get; set; }

        /// <summary>
        /// 红包使用结束时间（绝对时间为具体日期时间，相对时间为数字天数）
        /// </summary>
        public string GmtCouExpired { get; set; }

        /// <summary>
        /// 使用结束时间类型（"A"=绝对时间，"R"=相对时间）
        /// </summary>
        public string GmtCouRel { get; set; }

        /// <summary>
        /// 领用结束时间
        /// </summary>
        public string GmtDrawEnd { get; set; }

        /// <summary>
        /// 是否允许累加使用（"Y"=允许，"N"=不允许）
        /// </summary>
        public string IsAllowAddUp { get; set; }

        /// <summary>
        /// 预估发行红包个数
        /// </summary>
        public string MaxPublishNum { get; set; }

        /// <summary>
        /// 模板创建幂等控制业务号（每个幂等业务号多次调用的参数必需一致，一个幂等业务号多次调用传递不同的业务参数不保证幂等性）
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 使用规则ID（线下提前沟通）
        /// </summary>
        public string PayBizRuleId { get; set; }

        /// <summary>
        /// 保证金账号（红包发放出资支付宝账号）
        /// </summary>
        public string PromiseAccount { get; set; }

        /// <summary>
        /// 红包活动地址
        /// </summary>
        public string PublishUrl { get; set; }

        /// <summary>
        /// 发行人账号（支付宝登录ID）
        /// </summary>
        public string PublisherEmail { get; set; }

        /// <summary>
        /// 发行人名称
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>
        /// 指定交易商户列表（最多支持5个，以分号分隔）
        /// </summary>
        public string Sellers { get; set; }

        /// <summary>
        /// 红包模板名称
        /// </summary>
        public string TemplateName { get; set; }

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
            return "alipay.coupon.template.create";
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
            parameters.Add("active_url", this.ActiveUrl);
            parameters.Add("amount", this.Amount);
            parameters.Add("coupon_name", this.CouponName);
            parameters.Add("cust_guarantee_amount", this.CustGuaranteeAmount);
            parameters.Add("draw_biz_rule_id", this.DrawBizRuleId);
            parameters.Add("gmt_cou_active", this.GmtCouActive);
            parameters.Add("gmt_cou_expired", this.GmtCouExpired);
            parameters.Add("gmt_cou_rel", this.GmtCouRel);
            parameters.Add("gmt_draw_end", this.GmtDrawEnd);
            parameters.Add("is_allow_add_up", this.IsAllowAddUp);
            parameters.Add("max_publish_num", this.MaxPublishNum);
            parameters.Add("out_order_no", this.OutOrderNo);
            parameters.Add("pay_biz_rule_id", this.PayBizRuleId);
            parameters.Add("promise_account", this.PromiseAccount);
            parameters.Add("publish_url", this.PublishUrl);
            parameters.Add("publisher_email", this.PublisherEmail);
            parameters.Add("publisher_name", this.PublisherName);
            parameters.Add("sellers", this.Sellers);
            parameters.Add("template_name", this.TemplateName);
            return parameters;
        }

        #endregion
    }
}
