using ListaParaFazer.Data;
using ListaParaFazer.Models.Entities;
using ListaParaFazer.Models.ViewModels;
using ListaParaFazer.Models.ViewModels.Tarefa;
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
            return Ok("Tudo certo com nossa api");
        }

        [HttpGet]
        [Route("tarefas")]
        public async Task<IActionResult> Get(
            [FromServices] AppDbContext context)
        {
            try
            {
                var tarefasViewModel = new List<ReadTarefaViewModel>();
                var tarefas = await context.TB_Tarefas.ToListAsync();

                if (tarefas == null)
                {
                    return NoContent();
                }

                //O c�digo abaixo pega a minha classe base que veio do banco e transforma na tarefa ViewModel.
                //Assim, ao inv�s de eu retorna minha meu modelo base em s�, vou retornar somente que desejo.
                //Em seguida eu adiciono cada nova classe em uma lista j� instaciada.
                foreach (var item in tarefas)
                {
                    var novaTarefa = new ReadTarefaViewModel()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Descricao = item.Descricao,
                        DiasParaRealizar = item.DiasParaRealizar,
                        DataInicial = item.DataInicial,
                        DataFinal = item.DataFinal,
                        Realizada = item.Realizada
                    };

                    tarefasViewModel.Add(novaTarefa);
                }

                return Ok(new ResultViewModel<List<ReadTarefaViewModel>>(tarefasViewModel));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResultViewModel<List<TarefaModel>>("LPFG001 - " + ex.Message));
            }
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
                return NotFound("Tarefa n�o encontrada");
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
                return BadRequest("N�o foi possivel encontrar uma tarefa");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "0001x - Algo deu errado!");
            }
        }

        //[HttpPut]
        //[Route("Tarefas")]
        //public async Task<IActionResult> Update(
        //    [FromServices] AppDbContext context,
        //    [FromBody] DeleteTarefaViewModel deleteTarefaViewModel)
        //{
        //}
}