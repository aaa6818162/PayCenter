using System;
using PayCenterSdk.Model;

namespace PayCenterSdk
{
    public class TestDictionary
    {
        /// <summary>
        /// 从数据库中获取数据
        /// </summary>
        /// <param name="Partner"></param>
        /// <returns></returns>
        public static PayCenterRequest GetTestByPartnerId(string Partner="")
        {
            return new PayCenterRequest()
            {
                Partner = "商户",
               // PartnerToken="1111111",
                UserName = "UserName",
                UserId = "UserId",
                OrderNo = DateTime.Now.ToString("yyyyMMddHH"),
                TotalFee = 0.01m,
                PayRemark = "备注信息",
                PayType = PayEnum.PayCenter,
                SubmitTime = DateTime.Now.Date,
                PayCenterConfig = new PayCenterConfig()
                {
                    Partner = "商户",
                    Gateway = "http://localhost:24131/Portal/Index?",
                    Md5Key = "123456",
                    NotifyUrl = "http://localhost:45490/Pay/PayResultNotify?",
                    ReturnUrl = "http://localhost:45490/Pay/PayResult?",
                    //InputCharset = "utf-8",
                    //SignType = "MD5",
                }
            };



        }




    }
}
