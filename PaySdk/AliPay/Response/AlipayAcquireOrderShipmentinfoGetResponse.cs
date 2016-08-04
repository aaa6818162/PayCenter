using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAcquireOrderShipmentinfoGetResponse.
    /// </summary>
    public class AlipayAcquireOrderShipmentinfoGetResponse : AopResponse
    {
        /// <summary>
        /// 派件员手机号
        /// </summary>
        [XmlElement("delivery_mobile")]
        public string DeliveryMobile { get; set; }

        /// <summary>
        /// 派件员姓名
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 物流运单号
        /// </summary>
        [XmlElement("logistics_bill_no")]
        public string LogisticsBillNo { get; set; }

        /// <summary>
        /// 物流公司code
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人固定电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 物流流转信息
        /// </summary>
        [XmlArray("step_infos")]
        [XmlArrayItem("logistics_step_info")]
        public List<LogisticsStepInfo> StepInfos { get; set; }
    }
}
