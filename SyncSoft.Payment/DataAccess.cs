using System;
using SyncSoft.Payment.Config;

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




    }
}
