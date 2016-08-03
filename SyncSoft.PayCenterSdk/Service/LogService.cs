using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using SyncSoft.PayCenterSdk.Service.Interface;

namespace SyncSoft.PayCenterSdk.Service
{
    public class LogService : ILogService
    {
        #region Implementation of ILogService

        public void LogInfo(object logMessage)
        {
            string strPath = @"c:\log";
            if (!System.IO.File.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }
            strPath = strPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(strPath) == true)
            {
                FileStream myFs = new FileStream(strPath, FileMode.Create);
                myFs .Close();
            }

            StreamWriter fs = new StreamWriter(strPath, false, System.Text.Encoding.Default);
            fs.Write(JsonConvert.SerializeObject(logMessage));
            fs.Close();
        }

        #endregion
    }
}
