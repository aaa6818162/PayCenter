using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.member.card.template.save
    /// </summary>
    public class AlipayMemberCardTemplateSaveRequest : IAopRequest<AlipayMemberCardTemplateSaveResponse>
    {
        /// <summary>
        /// 支付宝会员卡模板Id
        /// </summary>
        public string AlipayTemplateId { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        public string ApplyExplain { get; set; }

        /// <summary>
        /// 权益描述集合，json结构，单个权益描述可选Key如下：  title：权益标题；  benefitDesc：权益描述  benefitRange：特权使用范围-- GLOBAL：通用特权； CITY：城市特权； SHOP：门店特权。  city：城市码，当benefit_range为CITY时，该属性不能为空。  shop：门店码，当benefitRange为SHOP时，该属性不能为空。
        /// </summary>
        public List<string> BenifitConfigList { get; set; }

        /// <summary>
        /// 发卡机构。  ALIPAY：支付宝  PARTNER：合作商户
        /// </summary>
        public string CardInst { get; set; }

        /// <summary>
        /// 卡商户信息，json格式。  目前仅支持如下key：  merchantUniId：商户唯一标识  merchantUniIdType：支持以下3种取值。    LOGON_ID：商户登录ID，邮箱或者手机号格式；    UID：商户的支付宝用户号，以2088开头的16位纯数字组成；    BINDING_MOBILE：商户支付宝账号绑定的手机号。    注意：  本参数主要用于发卡平台接入场景，request_from为PLATFORM时，不能为空。
        /// </summary>
        public string CardMerchantInfo { get; set; }

        /// <summary>
        /// 会员卡名称
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 卡类型。  MEMBER_CARD：会员卡  FUND_CARD：资金卡
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 统一服务电话
        /// </summary>
        public string ContactTel { get; set; }

        /// <summary>
        /// 卡显示配置，json结构，可选key如下：  displayBalance：是否显示余额，布尔值，下同；  displayLevel：是否展示等级；  displayPoint：是否显示积分；  displayStore：是否展示门店信息；  displayTelephone：是否展示统一联系电话
        /// </summary>
        public string DisplayConfig { get; set; }

        /// <summary>
        /// 扩展信息，json格式。
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 资金卡发行面额配置集合，json结构,当card_type为FUND_CARD时，该配置不能为空，单个发行面额可选key如下：  denomination：面额  discount：折扣  validDate：面额日期，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        public List<string> IssuedConfigList { get; set; }

        /// <summary>
        /// 商家简介
        /// </summary>
        public string MerchantIntroduction { get; set; }

        /// <summary>
        /// 外部商户卡模板Id
        /// </summary>
        public string OutTemplateId { get; set; }

        /// <summary>
        /// 请求来源。  PLATFORM：发卡平台商  PARTNER：直联商户
        /// </summary>
        public string RequestFrom { get; set; }

        /// <summary>
        /// 模板状态，目前只支持发行状态。  发行：PUBLISH
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 卡样式配置，json结构，可选Key如下：  logoUrl：图片链接，图片为正方形，推荐大小92*92  backgroundUrl：背景链接，图片为长方形，推荐大小534*318
        /// </summary>
        public string StyleConfig { get; set; }

        /// <summary>
        /// 有效期类型  Interval：固定时间段；  DeadLine：截止时间
        /// </summary>
        public string ValidDateType { get; set; }

        /// <summary>
        /// 有效期值  Interval：0-永久,比如1\12\24（月为单位）；  DeadLine：格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string ValidDateValue { get; set; }

        /// <summary>
        /// 核销方式。  QRCODE：二维码  DQRCODE：动态二维码  WAVE：声波  BARCORE：条码  DBARCORE：动态条码  TEXT：文本
        /// </summary>
        public string WriteOffType { get; set; }

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
            return "alipay.member.card.template.save";
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
            parameters.Add("alipay_template_id", this.AlipayTemplateId);
            parameters.Add("apply_explain", this.ApplyExplain);
            parameters.Add("benifit_config_list", this.BenifitConfigList);
            parameters.Add("card_inst", this.CardInst);
            parameters.Add("card_merchant_info", this.CardMerchantInfo);
            parameters.Add("card_name", this.CardName);
            parameters.Add("card_type", this.CardType);
            parameters.Add("contact_tel", this.ContactTel);
            parameters.Add("display_config", this.DisplayConfig);
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("issued_config_list", this.IssuedConfigList);
            parameters.Add("merchant_introduction", this.MerchantIntroduction);
            parameters.Add("out_template_id", this.OutTemplateId);
            parameters.Add("request_from", this.RequestFrom);
            parameters.Add("status", this.Status);
            parameters.Add("style_config", this.StyleConfig);
            parameters.Add("valid_date_type", this.ValidDateType);
            parameters.Add("valid_date_value", this.ValidDateValue);
            parameters.Add("write_off_type", this.WriteOffType);
            return parameters;
        }

        #endregion
    }
}
