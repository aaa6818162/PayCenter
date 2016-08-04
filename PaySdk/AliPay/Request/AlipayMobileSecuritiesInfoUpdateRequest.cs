using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.securities.info.update
    /// </summary>
    public class AlipayMobileSecuritiesInfoUpdateRequest : IAopUploadRequest<AlipayMobileSecuritiesInfoUpdateResponse>
    {
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 文本正文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Html格式正文
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public string Identify { get; set; }

        /// <summary>
        /// 原文链接
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 配图原图
        /// </summary>
        public FileItem OriginalPicture { get; set; }

        /// <summary>
        /// 配图图注
        /// </summary>
        public string PictureComment { get; set; }

        /// <summary>
        /// Html格式正文中配图图片位置标识
        /// </summary>
        public string PictureLocation { get; set; }

        /// <summary>
        /// publish_time
        /// </summary>
        public string PublishTime { get; set; }

        /// <summary>
        /// 相关股票
        /// </summary>
        public string RelevantStock { get; set; }

        /// <summary>
        /// 新闻来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }

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
            return "alipay.mobile.securities.info.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("author", this.Author);
            parameters.Add("content", this.Content);
            parameters.Add("html", this.Html);
            parameters.Add("identify", this.Identify);
            parameters.Add("link", this.Link);
            parameters.Add("picture_comment", this.PictureComment);
            parameters.Add("picture_location", this.PictureLocation);
            parameters.Add("publish_time", this.PublishTime);
            parameters.Add("relevant_stock", this.RelevantStock);
            parameters.Add("source", this.Source);
            parameters.Add("summary", this.Summary);
            parameters.Add("title", this.Title);
            parameters.Add("update_time", this.UpdateTime);
            return parameters;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("original_picture", this.OriginalPicture);
            return parameters;
        }

        #endregion
    }
}
