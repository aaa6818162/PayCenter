using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingSharetokenCreateResponse.
    /// </summary>
    public class AlipayMarketingSharetokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 吱口令失效时间，若为空则表示永久有效
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [XmlElement("share_token")]
        public string ShareToken { get; set; }

        /// <summary>
        /// 吱口令生效时间
        /// </summary>
        [XmlArray("start_date")]
        [XmlArrayItem("date")]
        public List<string> StartDate { get; set; }
    }
}
