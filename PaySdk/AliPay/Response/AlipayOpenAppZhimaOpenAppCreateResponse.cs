using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppZhimaOpenAppCreateResponse.
    /// </summary>
    public class AlipayOpenAppZhimaOpenAppCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("biz_success")]
        public string BizSuccess { get; set; }

        /// <summary>
        /// 创建成功还是失败
        /// </summary>
        [XmlElement("create_result")]
        public string CreateResult { get; set; }

        /// <summary>
        /// json字符串
        /// </summary>
        [XmlElement("json_pojo")]
        public string JsonPojo { get; set; }
    }
}
