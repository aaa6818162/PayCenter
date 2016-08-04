using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineKhomeOrderSpUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineKhomeOrderSpUpdateModel : AopObject
    {
        /// <summary>
        /// 平台商手艺人支付宝帐号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 平台商手艺人身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 平台商手艺人的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlArray("district_code_list")]
        [XmlArrayItem("string")]
        public List<string> DistrictCodeList { get; set; }

        /// <summary>
        /// 平台商手艺人id
        /// </summary>
        [XmlElement("external_sp_id")]
        public string ExternalSpId { get; set; }

        /// <summary>
        /// 平台商手艺人位置纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 证照信息列表
        /// </summary>
        [XmlArray("license_list")]
        [XmlArrayItem("khome_sp_license")]
        public List<KhomeSpLicense> LicenseList { get; set; }

        /// <summary>
        /// 平台商手艺人位置经度
        /// </summary>
        [XmlElement("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 平台商手艺人手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 平台商手艺人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
