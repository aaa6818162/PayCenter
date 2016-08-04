using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvShopTable Data Structure.
    /// </summary>
    [Serializable]
    public class IsvShopTable : AopObject
    {
        /// <summary>
        /// 最大容量
        /// </summary>
        [XmlElement("max")]
        public long Max { get; set; }

        /// <summary>
        /// 最小容量
        /// </summary>
        [XmlElement("min")]
        public long Min { get; set; }

        /// <summary>
        /// 0空闲 1 占用 2 不可知
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 座位ID， 必填
        /// </summary>
        [XmlElement("table_id")]
        public string TableId { get; set; }

        /// <summary>
        /// 餐桌名称
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 餐桌类型：  1:普通桌;  2:包厢
        /// </summary>
        [XmlElement("table_type")]
        public long TableType { get; set; }
    }
}
