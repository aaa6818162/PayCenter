using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillDownloadurlNoauthGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillDownloadurlNoauthGetModel : AopObject
    {
        /// <summary>
        /// 账单时间：日账单格式为yyyy-MM-dd，月账单格式为yyyy-MM。
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型，目前支持的类型由：trade、air、air_b2b；trade指商户通过接口所获取的账单，或商户经开放平台授权后其所属服务商通过接口所获取的账单；air、air_b2b是航旅行业定制的账单，一般商户没有此账单。
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }
    }
}
