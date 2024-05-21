using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace ListaParaFazer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListaParaFazer : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            return Ok("Tudo certo com nossa api!");
        }
    }
}