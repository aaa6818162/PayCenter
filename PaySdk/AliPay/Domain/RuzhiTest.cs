using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuzhiTest Data Structure.
    /// </summary>
    [Serializable]
    public class RuzhiTest : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 朋友的名字
        /// </summary>
        [XmlArray("friend_names")]
        [XmlArrayItem("string")]
        public List<string> FriendNames { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 体重，单位是千克
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }
    }
}
