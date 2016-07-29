using System;
using SyncSoft.PayCenterSdk.Config;
using SyncSoft.PayCenterSdk.Request;

namespace SyncSoft.PayCenterSdk.Response
{
    public class PayCenterResponse : PayCenterRequest
    {
        public bool IsSuccess { get; set; }

    }
}
