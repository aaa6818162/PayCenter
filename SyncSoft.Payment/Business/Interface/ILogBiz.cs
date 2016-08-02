namespace SyncSoft.Payment.Business.Interface
{
    public interface ILogBiz
    {
        void LogInfo(object logMessage);
    }

    public class LogMessage
    {
        public string Txt { get; set; }
    }
}
