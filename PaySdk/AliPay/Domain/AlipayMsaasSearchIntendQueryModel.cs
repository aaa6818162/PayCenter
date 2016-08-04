using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasSearchIntendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasSearchIntendQueryModel : AopObject
    {
        /// <summary>
        /// 搜索框场景code
        /// </summary>
        [XmlElement("action_src")]
        public string ActionSrc { get; set; }

        /// <summary>
        /// 用户当前选择的城市（如果有的话）
        /// </summary>
        [XmlElement("current_city")]
        public string CurrentCity { get; set; }

        /// <summary>
        /// 经度,纬度
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 传递给nlu的参数，json格式
        /// </summary>
        [XmlElement("nlu_param")]
        public string NluParam { get; set; }

        /// <summary>
        /// 表示在同一sessionid中的第几次搜索
        /// </summary>
        [XmlElement("query_index")]
        public string QueryIndex { get; set; }

        /// <summary>
        /// search_id,由调用放生成uuid，如果不传search系统会生成uuid
        /// </summary>
        [XmlElement("search_id")]
        public string SearchId { get; set; }

        /// <summary>
        /// 表示来源的业务，用于记录日志做数据统计
        /// </summary>
        [XmlElement("search_src")]
        public string SearchSrc { get; set; }

        /// <summary>
        /// 由调用方生成的uuid，用于唯一标示一次搜索会话
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
