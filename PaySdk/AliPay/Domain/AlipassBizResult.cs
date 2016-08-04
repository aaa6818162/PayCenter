using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipassBizResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipassBizResult : AopObject
    {
        /// <summary>
        /// Alipass ID
        /// </summary>
        [XmlElement("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// Alipass同步结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// Alipass唯一业务标识，由商户确保其唯一性。在json返回结果中为serialNumber
        /// </summary>
        [XmlElement("serial_number")]
        public string SerialNumber { get; set; }
    }
}
