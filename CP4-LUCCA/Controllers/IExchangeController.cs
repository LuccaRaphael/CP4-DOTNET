using Microsoft.AspNetCore.Mvc;

namespace cp4_exchange_api.Controllers
{
    public interface IExchangeController
    {
        JsonResult GetExchangeRate();
    }

    
}