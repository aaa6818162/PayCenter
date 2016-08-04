﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Aop.Api.Parser;
using Aop.Api.Request;
using Aop.Api.Util;

namespace Aop.Api
{
    /// <summary>
    /// AOP客户端。
    /// </summary>
    public class DefaultAopClient : IAopClient
    {
        public const string APP_ID = "app_id";
        public const string FORMAT = "format";
        public const string METHOD = "method";
        public const string TIMESTAMP = "timestamp";
        public const string VERSION = "version";
        public const string SIGN_TYPE = "sign_type";
        public const string ACCESS_TOKEN = "auth_token";
        public const string SIGN = "sign";
        public const string TERMINAL_TYPE = "terminal_type";
        public const string TERMINAL_INFO = "terminal_info";
        public const string PROD_CODE = "prod_code";
        public const string NOTIFY_URL="notify_url";
        public const string CHARSET = "charset";

        private string version;
        private string format;
        private string serverUrl;
        private string appId;
        private string privateKeyPem;
        private string signType = "RSA";
        private string charset;
        private string alipayPublicKey;
        private bool isFileKey = false;
        private WebUtils webUtils;

        public string Version
        {
            get { return version != null ? version : "1.0"; }
            set { version = value; }
        }

        public string Format
        {
            get { return format != null ? format : "json"; }
            set { format = value; }
        }

        public string AppId
        {
            get { return appId; }
            set { appId = value; }
        }

        #region DefaultAopClient Constructors

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem)
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format)
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.format = format;
            this.webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
            : this(serverUrl, appId, privateKeyPem, format)
        {
            this.charset = charset;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType)
            : this(serverUrl, appId, privateKeyPem)
        {
            this.format = format;
            this.version = version;
            this.signType = signType;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey)
            : this(serverUrl, appId, privateKeyPem, format, version, signType)
        {
            this.alipayPublicKey = alipayPulicKey;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.charset = charset;
        }
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset,bool isFileKey)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey,charset)
        {
            this.isFileKey = isFileKey;
        }

        public void SetTimeout(int timeout)
        {
            webUtils.Timeout = timeout;
        }

        #endregion

        #region IAopClient Members

        public T Execute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return Execute(request, null);
        }


        public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {
            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = "utf-8";
            }

            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            // 添加协议级请求参数
            AopDictionary txtParams = new AopDictionary(request.GetParameters());
            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, appId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(NOTIFY_URL,request.GetNotifyUrl());
            txtParams.Add(CHARSET, charset);

            // 添加签名参数
            if(isFileKey)
            txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset));
            else
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider {PersistKeyInCsp = false};
                rsa.LoadPublicKeyPEM(privateKeyPem);
                txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, rsa, charset));
                
            }



            // 是否需要上传文件
            string body;


            if (request is IAopUploadRequest<T>)
            {
                IAopUploadRequest<T> uRequest = (IAopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl + "?" + CHARSET + "=" + this.charset, txtParams, fileParams, this.charset);
            }
            else
            {
                body = webUtils.DoPost(this.serverUrl + "?" + CHARSET + "=" + this.charset, txtParams, this.charset);
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            CheckResponseSign(request, rsp, parser, this.alipayPublicKey, this.charset);

            return rsp;
        }

        protected virtual void CheckResponseSign<T>(IAopRequest<T> request, T tRsp, IAopParser<T> parser, string alipayPublicKey, string charset) where T : AopResponse
        {
            if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
            {
                return;
            }

            SignItem signItem = parser.GetSignItem(request, tRsp);
            if (signItem == null)
            {
                throw new AopException("sign check fail: Body is Empty!");
            }

            if (!tRsp.IsError ||
                (tRsp.IsError && !string.IsNullOrEmpty(signItem.Sign)))
            {
                bool rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        string srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        bool jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, charset);
                        if (!jsonCheck)
                        {
                            throw new AopException(
                                "sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AopException(
                                    "sign check fail: check Sign and Data Fail!");
                    }
                }

            }
        }

        #endregion
    }
}
