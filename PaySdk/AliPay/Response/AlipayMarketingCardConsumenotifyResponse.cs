using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardConsumenotifyResponse.
    /// </summary>
    public class AlipayMarketingCardConsumenotifyResponse : AopResponse
    {
        /// <summary>
        /// 外部卡号
        /// </summary>
        [XmlElement("external_card_no")]
        public string ExternalCardNo { get; set; }
    }
}
