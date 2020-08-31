using Newtonsoft.Json;

namespace Paystack.Core
{    
    public class TransferOtpResponse : HasRawResponse
    {

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}