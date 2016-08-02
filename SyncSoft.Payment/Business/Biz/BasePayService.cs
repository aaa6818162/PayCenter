using SyncSoft.Payment.Business.Interface;

namespace SyncSoft.Payment.Business.Biz
{
    public abstract class BasePayBiz
    {

        public ILogBiz log = new LogBiz();
    }
}
