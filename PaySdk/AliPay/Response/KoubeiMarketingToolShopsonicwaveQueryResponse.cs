using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingToolShopsonicwaveQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolShopsonicwaveQueryResponse : AopResponse
    {
        /// <summary>
        /// 表示店铺声音是否已经存在 如果是第一次从声波平台生成 exists为0; 否则为1
        /// </summary>
        [XmlElement("exists")]
        public string Exists { get; set; }

        /// <summary>
        /// 声波id 与声波文件唯一对应
        /// </summary>
        [XmlElement("sonic_id")]
        public string SonicId { get; set; }

        /// <summary>
        /// 声波音频CDN文件
        /// </summary>
        [XmlElement("sonic_path")]
        public string SonicPath { get; set; }
    }
}
