using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.sign.add
    /// </summary>
    public class AlipayEbppPdeductSignAddRequest : IAopRequest<AlipayEbppPdeductSignAddResponse>
    {
        /// <summary>
        /// PUBLICPLATFORM：服务窗
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 从服务窗发起则为publicId的值
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 签约类型  direct_sign_deduct：签约直连代扣
        /// </summary>
        public string DeductType { get; set; }

        /// <summary>
        /// 扩展参数。必须以key value形式定义，  转为json为格式：{"key1":"value1","key2":"value2",  "key3":"value3","key4":"value4"}   后端会直接转换为MAP对象，转换异常会报参数格式错误
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置
        /// </summary>
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 外部产生的协议ID
        /// </summary>
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 户名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 支付工具设置。一期为空,使用默认配置。  默认使用余额+银行卡+余额宝
        /// </summary>
        public string PayConfig { get; set; }

        /// <summary>
        /// 通过调起极简客户端进行支付密码验证获得的token
        /// </summary>
        public string PayPasswordToken { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 签约到期时间。空表示无限期，一期固定传空。
        /// </summary>
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值
        /// </summary>
        public string SubBizType { get; set; }

        /// <summary>
        /// 通过服务窗拿到的openId
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
            return "alipay.ebpp.pdeduct.sign.add";
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
            parameters.Add("agent_channel", this.AgentChannel);
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("bill_key", this.BillKey);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("deduct_type", this.DeductType);
            parameters.Add("extend_field", this.ExtendField);
            parameters.Add("notify_config", this.NotifyConfig);
            parameters.Add("out_agreement_id", this.OutAgreementId);
            parameters.Add("owner_name", this.OwnerName);
            parameters.Add("pay_config", this.PayConfig);
            parameters.Add("pay_password_token", this.PayPasswordToken);
            parameters.Add("pid", this.Pid);
            parameters.Add("sign_expire_date", this.SignExpireDate);
            parameters.Add("sub_biz_type", this.SubBizType);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
