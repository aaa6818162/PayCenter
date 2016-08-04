using SyncSoft.Payment.Config;
using SyncSoft.Payment.Model.Config;

namespace SyncSoft.Payment
{
    public class DataAccess
    {
        /// <summary>
        /// 从数据库中获取数据
        /// </summary>
        /// <returns></returns>
        public static AlipayConfig GetAlipayConfig()
        {
            return new AlipayConfig()
            {
                Partner = "2088901681979910",
                Key = "dkku7npeasqk0c1je4obnl5msqvszw70",
                SellerEmail = "ec@harborhousehome.com",
                NotifyUrl = "http://localhost:24131/Portal/AlipayNotify",
                ReturnUrl = "http://localhost:24131/Portal/AlipayReturn"
            };

        }

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


        public static PartnerPayConfig GetPartnerPayConfig()
        {
            return new PartnerPayConfig()
            {
                AlipayConfig = GetAlipayConfig(),
                PayCenterConfig = GetPayCenterConfig(),
                CmbBankConfig = new CmbBankConfig()
                {
                    CmbGateway = "https://netpay.cmbchina.com/netpayment/BaseHttp.dll?PrePayC1?",
                    CmbReturnUrl = "http://localhost:24131/Portal/CmbReturn",
                    CmbKey = @"d:\bank\cmb\public.key",
                    CmbBranchId = "0571",
                    CmbCoNo = "007084",
                    Password = "191688",
                    Remark = "111"
                }
            };
        }


    }
}
