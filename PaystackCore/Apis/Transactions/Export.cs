﻿using System;
using Newtonsoft.Json;

namespace Paystack.Core
{
    public class TransactionExportRequest
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool? Settled { get; set; }

        // Had to go against the rule here (use of underscore), because of query params!
        public string Payment_Page { get; set; }

        public int? Customer { get; set; }
        
        public string Currency { get; set; }

        public int? Settlement { get; set; }

        public int? Amount { get; set; }

        public string Status { get; set; }
    }

    public class TransactionExport
    {
        public class Data
        {
            [JsonProperty("path")]
            public string Path { get; set; }
        }
    }

    public class TransactionExportResponse : HasRawResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public TransactionExport.Data Data { get; set; }
    }
}