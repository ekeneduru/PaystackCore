using Newtonsoft.Json;

namespace Paystack.Core
{
    public class SubAccountFetchData : SubAccountCreate.Data
    {
    }

    public class SubAccountFetchResponse : HasRawResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SubAccountFetchData Data { get; set; }
    }
}