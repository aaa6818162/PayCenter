using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsStepInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsStepInfo : AopObject
    {
        /// <summary>
        /// 流转信息的备注，此备注信息直接来自物流公司，备注信息的详细程度视个物流公司的不同而不同
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 流转信息发生事件
        /// </summary>
        [XmlElement("occur_date")]
        public string OccurDate { get; set; }
    }
}
