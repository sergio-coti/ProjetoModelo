using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoModelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemplosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teste mensagem!");
        }
    }
}
