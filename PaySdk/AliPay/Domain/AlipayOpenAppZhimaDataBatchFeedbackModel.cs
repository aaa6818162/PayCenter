using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppZhimaDataBatchFeedbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppZhimaDataBatchFeedbackModel : AopObject
    {
        /// <summary>
        /// 扩展业务参数
        /// </summary>
        [XmlElement("biz_ext_params")]
        public string BizExtParams { get; set; }

        /// <summary>
        /// 文件列名
        /// </summary>
        [XmlElement("columns")]
        public string Columns { get; set; }

        /// <summary>
        /// 文件
        /// </summary>
        [XmlElement("file")]
        public string File { get; set; }

        /// <summary>
        /// 反馈文件的数据编码
        /// </summary>
        [XmlElement("file_charset")]
        public string FileCharset { get; set; }

        /// <summary>
        /// 文件描述信息
        /// </summary>
        [XmlElement("file_description")]
        public string FileDescription { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 主键列名
        /// </summary>
        [XmlElement("primary_key_columns")]
        public string PrimaryKeyColumns { get; set; }

        /// <summary>
        /// 反馈数据条数
        /// </summary>
        [XmlElement("records")]
        public string Records { get; set; }

        /// <summary>
        /// 商户应用中录入的数据反馈类型
        /// </summary>
        [XmlElement("type_id")]
        public string TypeId { get; set; }
    }
}
