using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SendRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SendRuleDTO : AopObject
    {
        /// <summary>
        /// 满多少金额才能送券
        /// </summary>
        [XmlElement("min_cost")]
        public string MinCost { get; set; }
    }
}
