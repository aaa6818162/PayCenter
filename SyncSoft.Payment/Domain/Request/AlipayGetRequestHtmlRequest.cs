using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.Payment.Config;
using SyncSoft.Payment.Model;
using SyncSoft.Payment.Model.Config;

namespace SyncSoft.Payment.Domain.Request
{
    public class AlipayGetRequestHtmlRequest
    {

        public AlipayGetRequestHtmlRequest()
        {
            OrderModel = new OrderModel();
            PartnerPayConfig = new PartnerPayConfig();
        }

        /// <summary>
        /// 
        /// </summary>
        public OrderModel OrderModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PartnerPayConfig PartnerPayConfig { get; set; }

    }
}
