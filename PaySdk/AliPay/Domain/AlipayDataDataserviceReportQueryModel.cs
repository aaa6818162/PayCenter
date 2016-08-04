using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceReportQueryModel : AopObject
    {
        /// <summary>
        /// 查询报表数据的业务日期列表，精确到天，格式为yyyymmdd，支持列表格式，数据按天返回
        /// </summary>
        [XmlArray("biz_date_list")]
        [XmlArrayItem("string")]
        public List<string> BizDateList { get; set; }

        /// <summary>
        /// 待查询商户在支付宝的合作id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 查询报表的类型，当前支持两种，TRADE-交易报表数据，ACTIVITY-活动报表数据
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 查询报表数据的门店列表，数据返回会把符合门店列表中的条件的数据进行汇总返回
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }

        /// <summary>
        /// report_type为ACTIVITY时才有效，查询报表数据的优惠模板列表，数据返回会把符合优惠模板列表中的条件的数据进行汇总返回
        /// </summary>
        [XmlArray("template_id_list")]
        [XmlArrayItem("string")]
        public List<string> TemplateIdList { get; set; }
    }
}
