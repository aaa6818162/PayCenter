using System;
using PayCenterSdk.Model;

namespace PayCenterSdk
{
    /// <summary>
    /// 移动端支付
    /// </summary>
    public class PayCenterAppRequest:PayCenterRequest
    {
        public PayAppEnum PayAppEnum { get; set; }
    }
}
