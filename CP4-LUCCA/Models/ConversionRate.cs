using Swashbuckle.AspNetCore.Annotations;

namespace cp4_exchange_api.Models

{
    public class ConversionRate : IConversionRate
    {
        [SwaggerSchema("Câmbio do USD para BRL.")]
        public double BRL { get; set; }
    }
}