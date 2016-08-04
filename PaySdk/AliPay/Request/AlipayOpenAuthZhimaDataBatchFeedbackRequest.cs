using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.auth.zhima.data.batch.feedback
    /// </summary>
    public class AlipayOpenAuthZhimaDataBatchFeedbackRequest : IAopUploadRequest<AlipayOpenAuthZhimaDataBatchFeedbackResponse>
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        public string BizExtParams { get; set; }

        /// <summary>
        /// 单条数据的数 据列,多个列 以逗号隔开
        /// </summary>
        public string Columns { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 反馈文件的数据 编码
        /// </summary>
        public string FileCharset { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        public string FileDescription { get; set; }

        /// <summary>
        /// 反馈的数据类 型,目前只支 持 json_data
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 主键列 主键 列使用反馈字 段进行组合, 也可以使用反 馈的某个单字 段(确保主键 稳定,而且可 以很好的区分 不同的数据)。 例如 order_no#pay_ month 或 者 order_no#bill_ month 组合, 对于一个order_no 只会 有一条数据的 情况,直接使 用 order_no 作 为主键列
        /// </summary>
        public string PrimaryKeyColumns { get; set; }

        /// <summary>
        /// 本次反馈的数 据条数
        /// </summary>
        public string Records { get; set; }

        /// <summary>
        /// 芝麻系统中配 置的值,由芝 麻信用提供, 需要匹配,测 试反馈和正式 反馈使用不同 的 type_id
        /// </summary>
        public string TypeId { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.auth.zhima.data.batch.feedback";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_ext_params", this.BizExtParams);
            parameters.Add("columns", this.Columns);
            parameters.Add("file_charset", this.FileCharset);
            parameters.Add("file_description", this.FileDescription);
            parameters.Add("file_type", this.FileType);
            parameters.Add("primary_key_columns", this.PrimaryKeyColumns);
            parameters.Add("records", this.Records);
            parameters.Add("type_id", this.TypeId);
            return parameters;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file", this.File);
            return parameters;
        }

        #endregion
    }
}
