﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace PayCenterSdk.Tool.Md5
{
    /// <summary>
    /// 类名：Submit
    /// 功能：支付宝各接口请求提交类
    /// 详细：构造支付宝各接口表单HTML文本，获取远程HTTP数据
    /// 版本：3.3
    /// 修改日期：2011-07-05
    /// 说明：
    /// 以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己网站的需要，按照技术文档编写,并非一定要使用该代码。
    /// 该代码仅供学习和研究支付宝接口使用，只是提供一个参考
    /// </summary>
    public class PayCenterMD5Submit
    {
        #region 字段

        private static string _gateway = "";
        //商户的私钥
        private string _key = "";
        //编码格式
        private string _input_charset = "";
        //签名方式
        private string _sign_type = "";
        #endregion

        public PayCenterMD5Submit(string gateway,  string key, string input_charset, string sign_type)
        {
            _gateway = gateway;
            _key = key.Trim();
            _input_charset = input_charset.Trim().ToLower();
            _sign_type = sign_type.Trim().ToUpper();
        }

        public PayCenterMD5Submit(string gateway)
        {
            _gateway = gateway;
            _input_charset = "utf-8";
        }

        /// <summary>
        /// 生成请求时的签名
        /// </summary>
        /// <param name="sPara">请求给支付宝的参数数组</param>
        /// <returns>签名结果</returns>
        private  string BuildRequestMysign(Dictionary<string, string> sPara)
        {
            //把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串
            string prestr = PayCenterMD5Core.CreateLinkString(sPara);

            //把最终的字符串签名，获得签名结果
            string mysign = "";
            switch (_sign_type)
            {
                case "MD5":
                    mysign = PayCenterMD5.Sign(prestr, _key, _input_charset);
                    break;
                default:
                    mysign = "";
                    break;
            }

            return mysign;
        }

        /// <summary>
        /// 生成要请求给支付宝的参数数组
        /// </summary>
        /// <param name="sParaTemp">请求前的参数数组</param>
        /// <returns>要请求的参数数组</returns>
        private  Dictionary<string, string> BuildRequestPara(SortedDictionary<string, string> sParaTemp)
        {
            //待签名请求参数数组
            Dictionary<string, string> sPara = new Dictionary<string, string>();
            //签名结果
            string mysign = "";

            //过滤签名参数数组
            sPara = PayCenterMD5Core.FilterPara(sParaTemp);

            //获得签名结果
            mysign = BuildRequestMysign(sPara);

            //签名结果与签名方式加入请求提交参数组中
            sPara.Add("sign", mysign);
            sPara.Add("sign_type", _sign_type);

            return sPara;
        }

        /// <summary>
        /// 生成要请求给支付宝的参数数组
        /// </summary>
        /// <param name="sParaTemp">请求前的参数数组</param>
        /// <param name="code">字符编码</param>
        /// <returns>要请求的参数数组字符串</returns>
        private  string BuildRequestParaToString(SortedDictionary<string, string> sParaTemp, Encoding code)
        {
            //待签名请求参数数组
            Dictionary<string, string> sPara = new Dictionary<string, string>();
            sPara = BuildRequestPara(sParaTemp);

            //把参数组中所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串，并对参数值做urlencode
            string strRequestData = PayCenterMD5Core.CreateLinkStringUrlencode(sPara, code);

            return strRequestData;
        }

        /// <summary>
        /// 建立请求，以表单HTML形式构造（默认）
        /// </summary>
        /// <param name="sParaTemp">请求参数数组</param>
        /// <param name="strMethod">提交方式。两个值可选：post、get</param>
        /// <param name="strButtonValue">确认按钮显示文字</param>
        /// <returns>提交表单HTML文本</returns>
        public  string BuildRequest(SortedDictionary<string, string> sParaTemp, string strMethod, string strButtonValue)
        {
            //待请求参数数组
            Dictionary<string, string> dicPara = new Dictionary<string, string>();
            dicPara = BuildRequestPara(sParaTemp);

            StringBuilder sbHtml = new StringBuilder();

            sbHtml.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + _gateway + "_input_charset=" + _input_charset + "' method='" + strMethod.ToLower().Trim() + "'>");

            foreach (KeyValuePair<string, string> temp in dicPara)
            {
                sbHtml.Append("<input type='hidden' name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }

            //submit按钮控件请不要含有name属性
            sbHtml.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");

            sbHtml.Append("<script>document.forms['alipaysubmit'].submit();</script>");

            return sbHtml.ToString();
        }


        /// <summary>
        /// 建立请求，以模拟远程HTTP的POST请求方式构造并获取支付的处理结果
        /// </summary>
        /// <param name="sParaTemp">请求参数数组</param>
        /// <returns>处理结果</returns>
        public string BuildRequest(SortedDictionary<string, string> sParaTemp)
        {
            Encoding code = Encoding.GetEncoding(_input_charset);

            //待请求参数数组字符串
            string strRequestData = BuildRequestParaToString(sParaTemp, code);

            //把数组转换成流中所需字节数组类型
            byte[] bytesRequestData = code.GetBytes(strRequestData);

            //构造请求地址
            string strUrl = _gateway + "_input_charset=" + _input_charset;

            //请求远程HTTP
            string strResult = "";
            try
            {
                //设置HttpWebRequest基本信息
                HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create(strUrl);
                myReq.Method = "post";
                myReq.ContentType = "application/x-www-form-urlencoded";

                //填充POST数据
                myReq.ContentLength = bytesRequestData.Length;
                Stream requestStream = myReq.GetRequestStream();
                requestStream.Write(bytesRequestData, 0, bytesRequestData.Length);
                requestStream.Close();

                //发送POST数据请求服务器
                HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();
                Stream myStream = HttpWResp.GetResponseStream();

                //获取服务器返回信息
                StreamReader reader = new StreamReader(myStream, code);
                StringBuilder responseData = new StringBuilder();
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    responseData.Append(line);
                }

                //释放
                myStream.Close();

                strResult = responseData.ToString();
            }
            catch (Exception exp)
            {
                strResult = "报错：" + exp.Message;
            }

            return strResult;
        }



        /// <summary>
        /// 用于防钓鱼，调用接口query_timestamp来获取时间戳的处理函数
        /// 注意：远程解析XML出错，与IIS服务器配置有关
        /// </summary>
        /// <returns>时间戳字符串</returns>
        public string Query_timestamp(string partner)
        {
            string url = _gateway + "service=query_timestamp&partner=" + partner + "&_input_charset=" + _input_charset;
            string encrypt_key = "";

            XmlTextReader Reader = new XmlTextReader(url);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Reader);

            encrypt_key = xmlDoc.SelectSingleNode("/alipay/response/timestamp/encrypt_key").InnerText;

            return encrypt_key;
        }
    }
}