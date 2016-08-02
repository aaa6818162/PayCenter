using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayCenterSdk.Model;

namespace PayCenterSdk
{
    public class PayCenterResponse : PayCenterRequest
    {


        /// <summary>
        /// 支付是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
    }
}
