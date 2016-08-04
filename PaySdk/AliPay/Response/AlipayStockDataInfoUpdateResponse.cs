using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayStockDataInfoUpdateResponse.
    /// </summary>
    public class AlipayStockDataInfoUpdateResponse : AopResponse
    {
        /// <summary>
        /// 操作成功与否
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
