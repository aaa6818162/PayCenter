using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncSoft.PayCenterSdk.Config;
using SyncSoft.PayCenterSdk.Model;
using SyncSoft.PayCenterSdk.Request;

namespace SyncSoft.PayCenterSdk
{
    public class TestDictionary
    {
        public static PayCenterRequest GetTestByPartnerId(string Partner="")
        {
            return new PayCenterRequest()
            {
                Partner = "商户",
               // PartnerToken="1111111",
                UserName = "UserName",
                UserId = "UserId",
                OrderNo = "0000000001",
                TotalFee = 0.01m,
                PayRemark = "备注信息",
                PayType = PayEnum.PayCenter,
                SubmitTime = DateTime.Now.Date,
                IsSuccess = true,
                PartnerConfig = new PartnerConfig()
                {
                    PayCenterConfig = new PayCenterConfig()
                    {
                        Partner = "商户",
                        Gateway = "http://localhost:24131/Portal/Index?",
                        Key = "123456",
                        NotifyUrl = "http://localhost:45490/Pay/PayResultNotify?",
                        ReturnUrl = "http://localhost:45490/Pay/PayResult?"
                    },
                    AlipayConfig = new AlipayConfig()
                    {
                        Partner = "2088901681979910",
                        Key = "dkku7npeasqk0c1je4obnl5msqvszw70",
                        SellerEmail = "ec@harborhousehome.com",
                        NotifyUrl = "http://localhost:24131/Portal/AlipayNotify",
                        ReturnUrl = "http://localhost:24131/Portal/AlipayReturn"
                    },
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
                }
            };



        }




    }
}
