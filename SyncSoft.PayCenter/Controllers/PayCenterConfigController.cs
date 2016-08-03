using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using PayCenterSdk;
using SyncSoft.PayCenter.Models;


namespace SyncSoft.PayCenter.Controllers
{
    public class PayCenterConfigController : ApiController
    {
        //public JsonResult<PayCenterConfig> GetPayCenterConfig()
        //{

        //    return Json(DataAccess.GetPayCenterConfig());
        //}

        [HttpPost]
        public JsonResult<PayCenterConfig> GetPayCenterConfig()
        {

            return Json(DataAccess.GetPayCenterConfig());
        }
    }
}
