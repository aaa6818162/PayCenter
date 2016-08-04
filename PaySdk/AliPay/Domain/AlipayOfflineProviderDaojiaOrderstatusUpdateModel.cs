using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderDaojiaOrderstatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderDaojiaOrderstatusUpdateModel : AopObject
    {
        /// <summary>
        /// 对修改价格的备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 修改后的应收金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }
    }
}
