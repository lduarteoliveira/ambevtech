using AmbevTech.Vendas.Comunication.Responses;
using AmbevTech.Vendas.Comunication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmbevTech.Vendas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterVendaJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterVendaJson request)
        {
            return Created();
        }
    }
}
