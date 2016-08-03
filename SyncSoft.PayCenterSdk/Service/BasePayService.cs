using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.PayCenterSdk.Service.Interface;

namespace SyncSoft.PayCenterSdk.Service
{
    public abstract class BasePayService
    {
        
       public ILogService log=new LogService();
    }
}
