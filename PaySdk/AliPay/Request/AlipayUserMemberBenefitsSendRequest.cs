using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.member.benefits.send
    /// </summary>
    public class AlipayUserMemberBenefitsSendRequest : IAopRequest<AlipayUserMemberBenefitsSendResponse>
    {
        /// <summary>
        /// 会员卡卡号
        /// </summary>
        public string BizCardNo { get; set; }

        /// <summary>
        /// 特权详情
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 失效日期。 格式：yyyy-mm-dd。
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 优惠券发放张数
        /// </summary>
        public Nullable<long> SendNum { get; set; }

        /// <summary>
        /// 流水号。 用于控制权益发放的幂等性。
        /// </summary>
        public string SerialNo { get; set; }

        /// <summary>
        /// 生效日期。 格式：yyyy-mm-d
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 特权名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 自定义核销码，如果为空则由支付宝自动生成
        /// </summary>
        public string VerifyCode { get; set; }

        /// <summary>
        /// 核销方式，可多选。 支持：test-纯文本，barcode-条码，qucode-二维码，wave-...
        /// </summary>
        public string VerifyTypes { get; set; }

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
            return "alipay.user.member.benefits.send";
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
            parameters.Add("biz_card_no", this.BizCardNo);
            parameters.Add("desc", this.Desc);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("send_num", this.SendNum);
            parameters.Add("serial_no", this.SerialNo);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("title", this.Title);
            parameters.Add("verify_code", this.VerifyCode);
            parameters.Add("verify_types", this.VerifyTypes);
            return parameters;
        }

        #endregion
    }
}
