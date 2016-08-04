using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataSendModel : AopObject
    {
        /// <summary>
        /// 场景的来源渠道，比如场景  在阿里旅行触发，就用alitrip
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 操作码
        /// </summary>
        [XmlElement("op_code")]
        public string OpCode { get; set; }

        /// <summary>
        /// 操作数据，如果只需要支付  宝这边利用数据直接完成某  个功能（通知等），则使用  此参数传输数据.
        /// </summary>
        [XmlElement("op_data")]
        public string OpData { get; set; }

        /// <summary>
        /// 场景标识,由支付宝分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景的数据表示. json 数组  格式
        /// </summary>
        [XmlElement("scene_data")]
        public string SceneData { get; set; }

        /// <summary>
        /// 场景覆盖的目标人群标识，  单个用户是支付宝的userId,  多个用户userId 使用英文半  角逗号隔开,最多200个  如果是群组,使用支付宝分配  的群组ID.
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 场景数据的类型的版本,由支付宝分配
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }
    }
}
