using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using cp4_exchange_api.Models;

namespace cp4_exchange_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangeController : ControllerBase, IExchangeController
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://v6.exchangerate-api.com/v6/de57eae077d496d8b855b3e3/latest/USD";

        public ExchangeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Obtém a taxa de câmbio mais recente do BRL.", Description = "Retorna a taxa de câmbio do USD para BRL.")]
        [SwaggerResponse(200, "Taxa de câmbio obtida com sucesso.", typeof(ConversionRate))]
        public async Task<JsonResult> GetExchangeRate()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(responseData);
                    var exchangeRate = json["conversion_rates"]?["BRL"]?.Value<double>();

                    if (exchangeRate.HasValue)
                    {
                        var valor = new ConversionRate
                        {
                            BRL = exchangeRate.Value
                        };

                        var result = new JsonResult(new
                        {
                            CurrencyPair = "USD/BRL",
                            Rate = valor.BRL,
                            Date = DateTime.Now
                        });

                        return result;
                    }
                    else
                    {
                        return new JsonResult(new { Error = "Taxa para BRL não encontrada." });
                    }
                }
                else
                {
                    return new JsonResult(new { Error = $"Erro na requisição: {response.StatusCode}" });
                }
            }
            catch (HttpRequestException httpEx)
            {
                return new JsonResult(new { Error = $"Erro na comunicação com a API: {httpEx.Message}" });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Error = $"Ocorreu um erro inesperado: {ex.Message}" });
            }
        }

        JsonResult IExchangeController.GetExchangeRate()
        {
            throw new NotImplementedException();
        }
    }
}