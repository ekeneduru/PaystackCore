using System;

namespace Paystack.Core
{
    public interface ISettlementsApi
    {
        SettlementsFetchResponse Fetch(DateTime? from = null, DateTime? to = null, string subaccount = "none");
    }
}