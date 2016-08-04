using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataNomoAntargusQueryResponse.
    /// </summary>
    public class AlipayDataNomoAntargusQueryResponse : AopResponse
    {
        /// <summary>
        /// 注释：  00：未知  01：历史涉嫌冒用，正常用户已经找回  02：历史涉嫌冒用，正常用户未找回  03：冒用
        /// </summary>
        [XmlElement("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 附加信息（用json格式表示）：  first_use_date：首次使用时间  last_use_date：最近使用时间  scene_type：  对应银行卡信息：01充值卡；02提现卡；03快捷卡；04其他转账卡  对应手机信息：11账户绑定手机；12快捷签约手机；13收货手机；14充值手机  对应地址信息：21收货地址
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 返回码：  -1：未知   0：否   1：是
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
