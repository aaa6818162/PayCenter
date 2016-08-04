using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCplifeServiceOrderRequestStatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeServiceOrderRequestStatusUpdateModel : AopObject
    {
        /// <summary>
        /// 业务明细备注
        /// </summary>
        [XmlElement("biz_details")]
        public string BizDetails { get; set; }

        /// <summary>
        /// 当前业务单状态
        /// </summary>
        [XmlElement("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务单据ID
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }
    }
}
