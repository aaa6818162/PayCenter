namespace PayCenterSdk
{
    public class DataAccessClient
    {
 

        public static PayCenterConfig GetPayCenterConfig()
        {
            return new PayCenterConfig()
            {
                Partner = "商户",
                Gateway = "http://localhost:24131/Portal/Index?",
                Md5Key = "123456",
                NotifyUrl = "http://localhost:45490/Pay/PayResultNotify?",
                ReturnUrl = "http://localhost:45490/Pay/PayResult?",
                //InputCharset = "utf-8",
                //SignType = "MD5",
            };

        }


    }
}
