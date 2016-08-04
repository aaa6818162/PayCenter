using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyncSoft.PayCenter.Models
{
    /// <summary>
    /// 统一api回调结果
    /// </summary>
    [Serializable]
    public class WebAPIResponse
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public int Code { get; set; }


        /// <summary>
        /// 返回结果
        /// </summary>
        public dynamic Result { get; set; }


        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Error Details
        /// </summary>
        public string Details { get; set; }

        public WebAPIResponse()
        {

        }
        public WebAPIResponse(bool success, int code, dynamic result, string message, string details)
        {
            this.Success = success;
            this.Code = code;
            this.Result = result;
            this.Message = message;
            this.Details = details;
        }



        #region Error
        /// <summary>
        /// 输错错误信息
        /// </summary>
        /// <returns></returns>
        public static WebAPIResponse Err()
        {
            return new WebAPIResponse()
            {
                Success = false
            };
        }
        /// <summary>
        /// 输错错误信息
        /// </summary>
        /// <param name="message">附属消息</param>
        /// <returns></returns>
        public static WebAPIResponse Err(string message, int code = 500)
        {
            return new WebAPIResponse()
            {
                Success = false,
                Message = message,
                Code = code
            };
        }

        #endregion

        #region Success
        /// <summary>
        /// 输出成功信息
        /// </summary>
        /// <returns></returns>
        public static WebAPIResponse Suc()
        {
            return new WebAPIResponse()
            {
                Success = true
            };
        }
        /// <summary>
        /// 输出成功信息
        /// </summary>
        /// <param name="message">附属消息</param>
        /// <returns></returns>
        public static WebAPIResponse Suc(string message)
        {
            return new WebAPIResponse()
            {
                Success = true,
                Message = message
            };
        }
        /// <summary>
        /// 输出成功信息
        /// </summary>
        /// <param name="data">附属数据</param>
        /// <returns></returns>
        public static WebAPIResponse Suc(object result)
        {
            return new WebAPIResponse()
            {
                Success = true,
                Code = 200,
                Result = result
            };
        }
        /// <summary>
        /// 输出成功信息
        /// </summary>
        /// <param name="result">附属数据</param>
        /// <param name="message">附属消息</param>
        /// <returns></returns>
        public static WebAPIResponse Suc(object result, string message)
        {
            return new WebAPIResponse()
            {
                Success = true,
                Result = result,
                Code = 200,
                Message = message
            };
        }

        #endregion


    }
}