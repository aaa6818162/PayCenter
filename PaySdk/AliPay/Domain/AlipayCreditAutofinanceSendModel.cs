using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCreditAutofinanceSendModel : AopObject
    {
        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("orderno")]
        public string Orderno { get; set; }
    }
}
