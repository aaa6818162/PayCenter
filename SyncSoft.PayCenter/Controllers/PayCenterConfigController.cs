using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using SyncSoft.PayCenter.Models;
using SyncSoft.Payment.Model.Config;


namespace SyncSoft.PayCenter.Controllers
{
    public class PayCenterConfigController : ApiController
    {

        [HttpPost]
        public JsonResult<PayCenterConfig> GetPayCenterConfig()
        {
            return Json(SyncSoft.Payment.DataAccess.GetPayCenterConfig());
        }
    }
}
