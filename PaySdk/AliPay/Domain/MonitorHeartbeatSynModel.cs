using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MonitorHeartbeatSynModel Data Structure.
    /// </summary>
    [Serializable]
    public class MonitorHeartbeatSynModel : AopObject
    {
        /// <summary>
        /// 发送心跳的设备ID，发起方为收银机，则为收银机设备的ID，设备ID最短长度6位；如没有设备ID，可填MAC地址
        /// </summary>
        [XmlElement("equipment_id")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 发送心跳时的设备状态：  10——开机/开启收银软件；  20——关机/关闭收银软件；  30——正常
        /// </summary>
        [XmlElement("equipment_status")]
        public string EquipmentStatus { get; set; }

        /// <summary>
        /// 心跳时间段内的机具异常原因，如有多个用“|”分隔。  HE_PRINTER——打印机异常；  HE_SCANER——扫描枪异常；  HE_OTHER——其他硬件异常
        /// </summary>
        [XmlElement("exception_info")]
        public string ExceptionInfo { get; set; }

        /// <summary>
        /// 扩展信息，心跳信息发送方自定义，json格式
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// Mac地址
        /// </summary>
        [XmlElement("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// pos设备连接的网络类型：2G、3G、WIFI、LAN。 LAN：有线网络
        /// </summary>
        [XmlElement("network_type")]
        public string NetworkType { get; set; }

        /// <summary>
        /// 发送心跳的设备所依赖的支付宝产品，发送心跳的设备所依赖的支付宝产品，目前仅支持FP：当面付产品
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 门店ID。需要和交易接口中的门店ID保持一致。 如无门店ID，请填“DF”
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 系统商编号
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 产生心跳的时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 两次心跳时间内的交易相关信息。包括期间所有交易的商户订单号、耗时和状态。最多发送前30笔交易信息。json格式，具体参见下面的“交易性能信息参数说明”。  多笔交易按时间顺序直接拼接。  如果由于网络等原因心跳发送失败，则该交易性能信息本地继续累积，直到有心跳发送成功后，本地数据才可以清除。  此数据非常重要，有交易则必填，无交易可传空
        /// </summary>
        [XmlElement("trade_info")]
        public string TradeInfo { get; set; }

        /// <summary>
        /// 发送心跳的设备类型：  CR——收银机；  STORE——门店；  VM——售卖
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
