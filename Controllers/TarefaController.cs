using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ListaParaFazer.Data;
using ListaParaFazer.Models.Entities;
using ListaParaFazer.Models.ViewModels.Tarefa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ListaParaFazer.Controllers
{
    [ApiController]
    public class ListaParaFazer : ControllerBase
    {
        [HttpGet]
        [Route("api")]
        public IActionResult GetResult()
        {
            return Ok("Tudo certo com nossa api");
        }

        [HttpGet]
        [Route("tarefas")]
        public async Task<IActionResult> Get(
            [FromServices] AppDbContext context)
        {
            var tarefas = await context.TB_Tarefas.ToListAsync();

            if (tarefas.Count() < 1)
            {
                return NoContent();
            }

            return Ok(tarefas);
        }

        [HttpGet]
        [Route("tarefas/{id:int}")]
        public async Task<IActionResult> GetById(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var tarefa = await context.TB_Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            if (tarefa == null)
            {
                return NotFound("Tarefa não encontrada");
            }

            return Ok(tarefa);
        }

        [HttpPost]
        [Route("tarefas")]
        public async Task<IActionResult> Post(
            [FromServices] AppDbContext context,
            [FromBody] CreateTarefaViewModel createTarefaViewModel)
        {
            var tarefa = new TarefaModel()
            {
                Title = createTarefaViewModel.Title,
                Descricao = createTarefaViewModel.Descricao,
                DiasParaRealizar = createTarefaViewModel.DiasParaRealizar,
                DataFinal = createTarefaViewModel.DataFinal
            };

            await context.TB_Tarefas.AddAsync(tarefa);
            context.SaveChanges();

            return Created($"tarefas/{tarefa.Id}", tarefa);
        }

        [HttpDelete]
        [Route("Tarefas")]
        public async Task<IActionResult> Delete(
            [FromServices] AppDbContext context,
            [FromBody] DeleteTarefaViewModel deleteTarefaViewModel)
        {
            try
            {
                var tarefa = await context.TB_Tarefas.FirstOrDefaultAsync(x => x.Id == deleteTarefaViewModel.Id);
                context.TB_Tarefas.Remove(tarefa);
                context.SaveChanges();

                return Ok(tarefa);

            }
            catch (ArgumentNullException ex)
            {
                return BadRequest("Não foi possivel encontrar uma tarefa");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "0001x - Algo deu errado!");
            }
        }
    }
}