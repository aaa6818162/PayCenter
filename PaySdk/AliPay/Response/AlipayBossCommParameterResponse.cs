using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossCommParameterResponse.
    /// </summary>
    public class AlipayBossCommParameterResponse : AopResponse
    {
        /// <summary>
        /// 根据卡号和instId查询得到的卡bin信息对象,当is_success=true时非空；反之，为空
        /// </summary>
        [XmlElement("card_bin_vo")]
        public CardBinVO CardBinVo { get; set; }

        /// <summary>
        /// 校验功能是否执行成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 接口执行结果的返回码描述  (SUCCESS=成功,CARD_BIN_NOT_MATCH=卡bin不匹配,SERVICE_ACCESS_FAILURE=服务端访问失败,CARD_NO_BLANK=CARD_NO_BLANK)
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 接口执行结果的返回码  (SUCCESS=成功,CARD_BIN_NOT_MATCH=卡bin不匹配,SERVICE_ACCESS_FAILURE=服务端访问失败,CARD_NO_BLANK=CARD_NO_BLANK)
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
