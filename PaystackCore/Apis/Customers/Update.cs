﻿using Newtonsoft.Json;

namespace Paystack.Core
{
    public class CustomerUpdateRequest : RequestMetadataExtender
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        public string Phone { get; set; }
    }

    public class CustomerUpdateResponse : HasRawResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CustomerList.Datum Data { get; set; }
    }
}