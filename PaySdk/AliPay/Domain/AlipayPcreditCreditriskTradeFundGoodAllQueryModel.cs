using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditCreditriskTradeFundGoodAllQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditCreditriskTradeFundGoodAllQueryModel : AopObject
    {
        /// <summary>
        /// sd
        /// </summary>
        [XmlElement("aaa")]
        public AddRemote Aaa { get; set; }

        /// <summary>
        /// fuzaleixing
        /// </summary>
        [XmlElement("complex")]
        public ShopIdList Complex { get; set; }

        /// <summary>
        /// aas
        /// </summary>
        [XmlElement("dfd")]
        public AlipayDataItemVoucherTemplete Dfd { get; set; }
    }
}
