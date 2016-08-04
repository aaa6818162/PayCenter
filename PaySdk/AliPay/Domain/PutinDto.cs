using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PutinDto Data Structure.
    /// </summary>
    [Serializable]
    public class PutinDto : AopObject
    {
        /// <summary>
        /// 口碑店铺展示
        /// </summary>
        [XmlArray("show_scene")]
        [XmlArrayItem("string")]
        public List<string> ShowScene { get; set; }
    }
}
