namespace SyncSoft.PayCenterSdk.Service.Interface
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
