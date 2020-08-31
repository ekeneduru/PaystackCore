using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Paystack.Core
{
    public interface IHasRawResponse
    {
        string RawJson { get; set; }
    }

    public class HasRawResponse : IHasRawResponse
    {
        public string RawJson { get; set; }
    }
}