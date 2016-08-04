using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductNotifyChannel Data Structure.
    /// </summary>
    [Serializable]
    public class DeductNotifyChannel : AopObject
    {
        /// <summary>
        /// 渠道ID。取值：  sms：短信  push：PUSH通知  todo：待办事项
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道名称。取值：短信/PUSH通知/待办事项
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }
    }
}
