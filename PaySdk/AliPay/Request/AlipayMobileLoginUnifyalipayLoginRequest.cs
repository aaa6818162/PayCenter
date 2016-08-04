using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.login.unifyalipay.login
    /// </summary>
    public class AlipayMobileLoginUnifyalipayLoginRequest : IAopRequest<AlipayMobileLoginUnifyalipayLoginResponse>
    {
        /// <summary>
        /// 用户无线接入点名称
        /// </summary>
        public string AccessPoint { get; set; }

        /// <summary>
        /// 环境上下文数据--RDS数据采集支付宝（由支付宝提供的JS或sdk采集的设备信息及用户行为信息）
        /// </summary>
        public string AlipayEnvJson { get; set; }

        /// <summary>
        /// 设备指纹
        /// </summary>
        public string Apdid { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        public string AppClientId { get; set; }

        /// <summary>
        /// 应用key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 手机基站
        /// </summary>
        public string CellId { get; set; }

        /// <summary>
        /// apple-iphone
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 456123
        /// </summary>
        public string CheckCode { get; set; }

        /// <summary>
        /// 校验码id
        /// </summary>
        public string CheckCodeId { get; set; }

        /// <summary>
        /// 终端位置（地理位置）
        /// </summary>
        public string ClientPostion { get; set; }

        /// <summary>
        /// 客户端类型(IOS,ANDRIOD)
        /// </summary>
        public string ClientType { get; set; }

        /// <summary>
        /// 扩展参数(json格式)
        /// </summary>
        public string ExternParams { get; set; }

        /// <summary>
        /// IMEI
        /// </summary>
        public string Imei { get; set; }

        /// <summary>
        /// IMSI
        /// </summary>
        public string Imsi { get; set; }

        /// <summary>
        /// 基站LAC
        /// </summary>
        public string LacId { get; set; }

        /// <summary>
        /// 登录帐号(手机号码或邮箱)
        /// </summary>
        public string LoginId { get; set; }

        /// <summary>
        /// 登陆密码（RSA加密后）
        /// </summary>
        public string LoginPwd { get; set; }

        /// <summary>
        /// 登录类型（TAOBAO或者ALIPAY）
        /// </summary>
        public string LoginType { get; set; }

        /// <summary>
        /// 手机品牌
        /// </summary>
        public string MobileBrand { get; set; }

        /// <summary>
        /// 手机机型
        /// </summary>
        public string MobileModel { get; set; }

        /// <summary>
        /// 设备是否越狱
        /// </summary>
        public Nullable<bool> PrisonBreak { get; set; }

        /// <summary>
        /// 屏幕高
        /// </summary>
        public string ScreenHigh { get; set; }

        /// <summary>
        /// 屏幕宽
        /// </summary>
        public string ScreenWidth { get; set; }

        /// <summary>
        /// 操作系统类型
        /// </summary>
        public string SystemType { get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        public string SystemVersion { get; set; }

        /// <summary>
        /// 标识
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// userAgent
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// 38:83:45:e4:76:c0
        /// </summary>
        public string WifiMac { get; set; }

        /// <summary>
        /// wifi 接入点名称
        /// </summary>
        public string WifiNodeName { get; set; }

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
            return "alipay.mobile.login.unifyalipay.login";
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
            parameters.Add("access_point", this.AccessPoint);
            parameters.Add("alipay_env_json", this.AlipayEnvJson);
            parameters.Add("apdid", this.Apdid);
            parameters.Add("app_client_id", this.AppClientId);
            parameters.Add("app_key", this.AppKey);
            parameters.Add("cell_id", this.CellId);
            parameters.Add("channel", this.Channel);
            parameters.Add("check_code", this.CheckCode);
            parameters.Add("check_code_id", this.CheckCodeId);
            parameters.Add("client_postion", this.ClientPostion);
            parameters.Add("client_type", this.ClientType);
            parameters.Add("extern_params", this.ExternParams);
            parameters.Add("imei", this.Imei);
            parameters.Add("imsi", this.Imsi);
            parameters.Add("lac_id", this.LacId);
            parameters.Add("login_id", this.LoginId);
            parameters.Add("login_pwd", this.LoginPwd);
            parameters.Add("login_type", this.LoginType);
            parameters.Add("mobile_brand", this.MobileBrand);
            parameters.Add("mobile_model", this.MobileModel);
            parameters.Add("prison_break", this.PrisonBreak);
            parameters.Add("screen_high", this.ScreenHigh);
            parameters.Add("screen_width", this.ScreenWidth);
            parameters.Add("system_type", this.SystemType);
            parameters.Add("system_version", this.SystemVersion);
            parameters.Add("token", this.Token);
            parameters.Add("user_agent", this.UserAgent);
            parameters.Add("wifi_mac", this.WifiMac);
            parameters.Add("wifi_node_name", this.WifiNodeName);
            return parameters;
        }

        #endregion
    }
}
