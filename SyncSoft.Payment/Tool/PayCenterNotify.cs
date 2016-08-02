﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using sdk;

namespace SyncSoft.Payment.Tool
{

    /// <summary>
    /// 异步通知
    /// </summary>
    public class PayCenterNotify
    {
        #region 字段
        private string _partner = "";               //合作身份者ID
        private string _key = "";                   //商户的私钥
        private string _input_charset = "";         //编码格式
        private string _sign_type = "";             //签名方式
        private bool _isNeedHttpsVeryfy = false;  //是否需要服务器验证
        private string _httpsVeryfyUrl = "https://mapi.alipay.com/gateway.do?service=notify_verify&";//消息验证地址
        #endregion


        /// <summary>
        /// 构造函数
        /// 从配置文件中初始化变量
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <param name="notify_id">通知验证ID</param>
        public PayCenterNotify(string partner, string key)
        {
            //初始化基础配置信息
            _partner = partner;
            _key = key;
            _input_charset = "utf-8";
            _sign_type = "MD5";
        }

        public PayCenterNotify(string partner, string key, bool isNeedHttpsVeryfy, string httpsVeryfyUrl)
        {
            //初始化基础配置信息
            _partner = partner;
            _key = key;
            _input_charset = "utf-8";
            _sign_type = "MD5";
            _isNeedHttpsVeryfy = isNeedHttpsVeryfy;
            _httpsVeryfyUrl = httpsVeryfyUrl;
        }


        /// <summary>
        ///  验证消息是否是发出的合法消息
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <param name="notify_id">通知验证ID</param>
        /// <param name="sign">生成的签名结果</param>
        /// <returns>验证结果</returns>
        public bool Verify(SortedDictionary<string, string> inputPara, string sign, string notify_id = "")
        {
            //获取返回时的签名验证结果
            bool isSign = GetSignVeryfy(inputPara, sign);

            if (!_isNeedHttpsVeryfy)
            {
                return isSign;
            }

            //获取是否是服务器发来的请求的验证结果
            string responseTxt = "true";
            if (notify_id != null && notify_id != "") { responseTxt = GetResponseTxt(notify_id); }

            //写日志记录（若要调试，请取消下面两行注释）
            //string sWord = "responseTxt=" + responseTxt + "\n isSign=" + isSign.ToString() + "\n 返回回来的参数：" + GetPreSignStr(inputPara) + "\n ";
            //PayCenterToolKit.LogResult(sWord);

            //判断responsetTxt是否为true，isSign是否为true
            //responsetTxt的结果不是true，与服务器设置问题、合作身份者ID、notify_id一分钟失效有关
            //isSign不是true，与安全校验码、请求时的参数格式（如：带自定义参数等）、编码格式有关
            if (responseTxt == "true" && isSign)//验证成功
            {
                return true;
            }
            else//验证失败
            {
                return false;
            }
        }

        /// <summary>
        /// 获取待签名字符串（调试用）
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <returns>待签名字符串</returns>
        private string GetPreSignStr(SortedDictionary<string, string> inputPara)
        {
            Dictionary<string, string> sPara = new Dictionary<string, string>();

            //过滤空值、sign与sign_type参数
            sPara = PayCenterToolKit.FilterPara(inputPara);

            //获取待签名字符串
            string preSignStr = PayCenterToolKit.CreateLinkString(sPara);

            return preSignStr;
        }

        /// <summary>
        /// 获取返回时的签名验证结果
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <param name="sign">对比的签名结果</param>
        /// <returns>签名验证结果</returns>
        private bool GetSignVeryfy(SortedDictionary<string, string> inputPara, string sign)
        {
            Dictionary<string, string> sPara = new Dictionary<string, string>();

            //过滤空值、sign与sign_type参数
            sPara = PayCenterToolKit.FilterPara(inputPara);

            //获取待签名字符串
            string preSignStr = PayCenterToolKit.CreateLinkString(sPara);

            //获得签名验证结果
            bool isSgin = false;
            if (sign != null && sign != "")
            {
                switch (_sign_type)
                {
                    case "MD5":
                        isSgin = MD5Helper.Verify(preSignStr, sign, _key, _input_charset);
                        break;
                    default:
                        break;
                }
            }

            return isSgin;
        }

        /// <summary>
        /// 获取是否是服务器发来的请求的验证结果
        /// </summary>
        /// <param name="notify_id">通知验证ID</param>
        /// <returns>验证结果</returns>
        private string GetResponseTxt(string notify_id)
        {
            string veryfy_url = _httpsVeryfyUrl + "partner=" + _partner + "&notify_id=" + notify_id;

            //获取远程服务器ATN结果，验证是否是服务器发来的请求
            string responseTxt = Get_Http(veryfy_url, 120000);

            return responseTxt;
        }

        /// <summary>
        /// 获取远程服务器ATN结果
        /// </summary>
        /// <param name="strUrl">指定URL路径地址</param>
        /// <param name="timeout">超时时间设置</param>
        /// <returns>服务器ATN结果</returns>
        private string Get_Http(string strUrl, int timeout)
        {
            string strResult;
            try
            {
                HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create(strUrl);
                myReq.Timeout = timeout;
                HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();
                Stream myStream = HttpWResp.GetResponseStream();
                StreamReader sr = new StreamReader(myStream, Encoding.Default);
                StringBuilder strBuilder = new StringBuilder();
                while (-1 != sr.Peek())
                {
                    strBuilder.Append(sr.ReadLine());
                }

                strResult = strBuilder.ToString();
            }
            catch (Exception exp)
            {
                strResult = "错误：" + exp.Message;
            }

            return strResult;
        }
    }
}
