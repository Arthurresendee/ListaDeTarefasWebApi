using System.Runtime.CompilerServices;
using ListaParaFazer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListaParaFazer.Controllers
{
    [ApiController]
    public class ListaParaFazer : ControllerBase
    {
        [HttpGet]
        [Route("api")]
        public IActionResult GetResult()
        {
            return Ok();
        }

        [HttpGet]
        [Route("tarefas")]
        public async Task<IActionResult> Get(
            [FromServices] AppDbContext context)
        {
            var tarefas = await context.Tarefas.ToListAsync();

            if (tarefas.Count() < 1)
            {
                return NoContent();
            }

            return Ok(tarefas);
        }
    }
}