using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KhomeSpLicense Data Structure.
    /// </summary>
    [Serializable]
    public class KhomeSpLicense : AopObject
    {
        /// <summary>
        /// 证照认证机构
        /// </summary>
        [XmlElement("agency")]
        public string Agency { get; set; }

        /// <summary>
        /// 证照过期时间
        /// </summary>
        [XmlElement("gmt_expire")]
        public string GmtExpire { get; set; }

        /// <summary>
        /// 证照有效期开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 证照图片的URL
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 认证结果，比如：高级
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 证照编号
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }

        /// <summary>
        /// 证照类型  HEALTH：健康证  BEAUTY：美容相关证件  MASSAGE：按摩师职业证书  TRANSPORT：道路运输证  DRIVING：驾驶证  TRANSPORT_PERMIT：道路运输经营许可
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
