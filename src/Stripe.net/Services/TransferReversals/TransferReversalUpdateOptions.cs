namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransferReversalUpdateOptions : BaseOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}