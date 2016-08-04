using System;
using System.Collections.Generic;
using Com.Alipay;
using Com.Alipay.Business;
using Com.Alipay.Domain;
using Com.Alipay.Model;
using SyncSoft.Payment.Business.Biz.Base;
using SyncSoft.Payment.Business.Interface;
using SyncSoft.Payment.Business.Interface.App;
using SyncSoft.Payment.Model.Config;

namespace SyncSoft.Payment.Business.Biz.App
{
    /// <summary>
    /// 支付宝应用端接口
    /// </summary>
    public class AliPayAppBiz : BasePayBiz, IAliPayAppBiz
    {
        #region Implementation of IAliPayAppBiz

        public void tradePay(string dynamic_id)
        {
            var config = new AlipayAppConfig();
            var _serviceClient = F2FBiz.CreateClientInstance(config.serverUrl,
                   config.appId,
                   config.merchant_private_key,
                   config.version,
                   config.sign_type, config.alipay_public_key, config.charset);

          var builder=  BuildPayContent(dynamic_id);

            AlipayF2FPayResult payResult = _serviceClient.tradePay(builder);

        }

        public void tradeQuery(string outTradeNo)
        {
            throw new System.NotImplementedException();
        }

        public void tradeQueryByAilipayNo(string TradeNo)
        {
            throw new System.NotImplementedException();
        }

        public void tradeRefund(string builder)
        {
            throw new System.NotImplementedException();
        }

        public void tradePrecreate(string builder)
        {
            throw new System.NotImplementedException();
        }

        public void tradePrecreate(string builder, string notify_url)
        {
            throw new System.NotImplementedException();
        }

        #endregion


        #region 私有方法
        private AlipayTradePayContentBuilder BuildPayContent(string dynamic_id)
        {
            //线上联调时，请输入真实的外部订单号。
            string out_trade_no = "";
            out_trade_no = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString();

            //扫码枪扫描到的用户手机钱包中的付款条码
            AlipayTradePayContentBuilder builder = new AlipayTradePayContentBuilder();

            builder.out_trade_no = out_trade_no;
            builder.scene = "bar_code";
            builder.auth_code = dynamic_id;
            builder.total_amount = "0.01";
            builder.discountable_amount = "0.01";
            builder.undiscountable_amount = "0";
            builder.operator_id = "test";
            builder.subject = "条码支付";
            builder.timeout_express = "2m";
            builder.body = "订单描述";
            builder.store_id = "test store id";    //很重要的参数，可以用作之后的营销     
            builder.seller_id = "";       //可以是具体的收款账号。

            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();

            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "goods id";
            goods.goods_name = "goods name";
            goods.price = "0.01";
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;
            //扩展参数
            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = "20880000000000";
            //builder.extendParams = exParam;

            return builder;

        }
        #endregion
    }
}
