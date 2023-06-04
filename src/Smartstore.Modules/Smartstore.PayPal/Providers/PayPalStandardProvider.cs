﻿using Smartstore.Core.Checkout.Orders;
using Smartstore.Core.Data;
using Smartstore.Core.Widgets;
using Smartstore.Engine.Modularity;
using Smartstore.PayPal.Client;
using Smartstore.PayPal.Components;

namespace Smartstore.PayPal.Providers
{
    [SystemName("Payments.PayPalStandard")]
    [FriendlyName("PayPal Standard")]
    [Order(1)]
    public class PayPalStandardProvider : PayPalProviderBase
    {
        public PayPalStandardProvider(SmartDbContext db, PayPalHttpClient client, PayPalSettings settings)
            : base(db, client, settings)
        {
        }

        public override Widget GetPaymentInfoWidget()
            => new ComponentWidget(typeof(PayPalViewComponent), true);
    }
}
