using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncSoft.PayCenterSdk.Service
{
    public interface ILogService
    {
        void LogInfo(object logMessage);
    }

    public class LogMessage
    {
        public string Txt { get; set; }
    }
}
