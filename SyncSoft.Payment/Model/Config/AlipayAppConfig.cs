namespace SyncSoft.Payment.Model.Config
{
    /// <summary>
    /// 支付宝支付实体
    /// </summary>
    public class AlipayAppConfig
    {
        /// <summary>
        /// 支付宝公钥
        /// </summary>
        public string alipay_public_key { get { return @"MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDDI6d306Q8fIfCOaTXyiUeJHkrIvYISRcc73s3vF1ZT7XN8RNPwJxo8pWaJMmvyTn9N4HQ632qJBVHf8sxHi/fEsraprwCtzvzQETrNRwVxLO5jVmRGi60j8Ue1efIlzPXV9je9mkjzOmdssymZkh2QhUrCmZYI/FCEa3/cNMW0QIDAQAB"; } }

        /// <summary>
        /// 商户私钥key
        /// </summary>
        public string merchant_private_key
        {
            get
            {
                return @"-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQDIDJ71AUFn8OY9mSbQM8HeLvthw6xu24OsiMto9IpsUu9c+bHG
5VZvoQAcOqM3sX/ENQvHkRQPP770LrWMpfhZRUJhEv5ST7bGoiJWZ3Gh5g9WzwaG
hnUUjzffIj3fQZ1G0ZVHBU5GhDEMfA5TogPxoXRgr16qbk6x8XvScSI3ZQIDAQAB
AoGASYo6NR8NCETKnwJZ/lfIgQEMcFgaX3Za5WY0QJUE/eVPEQLJk7BjIg4xmC8G
KUcbDOnjNq3ijeiFLgatvtKUhLZK7R8TPVxqb1TFhzP8IHXzse6Z6gf3UAN1lKEG
xTDz+uQb9q43XNsIsg/DCundPnY8tMpAzWD1Xhp4otINslECQQDihdi2HzvSQL0e
hmIfkj1o8T1UUSp8JZdsdMVd7dCgHB/CiSaW0Y/zL/oyObMh1fcg4zL7f10gDEvw
k/ZDqD0/AkEA4hTclXuKGpl865BvnErLdAUmrHB/K78ldrCnMQstcvNRu0jgnD3x
6y49w833yzJwHZWxuvQXGEAc+9x0kUUOWwJBAOExLr/fTRk4QsqVzfaU63foW4/3
IMVKmb64V32Jbl29l9VNg49rxi99Ar3rnqmEjKmlNInRlELH9ra0YZ3hIwECQA5P
K7b6Xr9YP6PZPHcz9LSfLtdzN1lZe9GLVMmx32qLI/0qm6zH7uvnvVkLTEe8JYR5
2QnwMRYD2NHIHkijikkCQQCNxPeEs99LoGPT6oq2HZ8XlQcXcik8syQqWj7oT3m8
g/MrCKoFh0sPStB86pyWIbOduwVuGq865Ch2N16kXrk2
-----END RSA PRIVATE KEY-----";
            }
        }

        /// <summary>
        /// 商户公钥key
        /// </summary>
        public string merchant_public_key
        {
            get
            {
                return @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDIDJ71AUFn8OY9mSbQM8HeLvth
w6xu24OsiMto9IpsUu9c+bHG5VZvoQAcOqM3sX/ENQvHkRQPP770LrWMpfhZRUJh
Ev5ST7bGoiJWZ3Gh5g9WzwaGhnUUjzffIj3fQZ1G0ZVHBU5GhDEMfA5TogPxoXRg
r16qbk6x8XvScSI3ZQIDAQAB
-----END PUBLIC KEY-----";
            }
        }

        /// <summary>
        /// 应用Id
        /// </summary>
        public string appId { get { return "2016030901197414"; } }

        /// <summary>
        /// api服务地址
        /// </summary>
        public string serverUrl { get { return "https://openapi.alipay.com/gateway.do"; } }

        /// <summary>
        /// 
        /// </summary>
        public string mapiUrl { get { return "https://mapi.alipay.com/gateway.do"; } }

        /// <summary>
        /// 监控地址
        /// </summary>
        public string monitorUrl { get { return "http://mcloudmonitor.com/gateway.do"; } }

        /// <summary>
        /// 商户Id
        /// </summary>
        public string pid { get { return "2088011754961990"; } }


        public string charset { get { return "utf-8"; } }
        public string sign_type { get { return "RSA"; } }
        public string version { get { return "1.0"; } }

    }
}
