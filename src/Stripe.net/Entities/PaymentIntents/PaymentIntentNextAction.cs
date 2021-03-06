namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextAction : StripeEntity
    {
        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
