using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMpointprodDispatchOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMpointprodDispatchOrderQueryModel : AopObject
    {
        /// <summary>
        /// 消息体内容，JSON格式，不含换行、空格参数:  userId: 支付用户ID, 可以直接传递openId  outBizNo:外部交易订单号
        /// </summary>
        [XmlElement("biz_content")]
        public string BizContent { get; set; }
    }
}
