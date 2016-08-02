using System;
using System.IO;
using Newtonsoft.Json;
using SyncSoft.Payment.Business.Interface;

namespace SyncSoft.Payment.Business.Biz
{
    public class LogBiz : ILogBiz
    {
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
                myFs.Close();
            }

            StreamWriter fs = new StreamWriter(strPath, false, System.Text.Encoding.Default);
            fs.Write(JsonConvert.SerializeObject(logMessage));
            fs.Close();
        }
    }

    public class LogMessage
    {
        public string Txt { get; set; }
    }
}
