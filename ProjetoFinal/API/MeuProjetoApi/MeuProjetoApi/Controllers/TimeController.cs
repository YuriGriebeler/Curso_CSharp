using MeuProjetoApi.BancoDados.Repositorios;
using MeuProjetoApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MeuProjetoApi.Controllers
{
    [ApiController]
    public class TimeController : ControllerBase
    {

        public TimeRepositorio Repositorio = new TimeRepositorio();

        [HttpGet]
        [Route("time/obterTodos")]
        public IActionResult ObterTodos()
        {
            try
            {
                var todasTimes = Repositorio.ObterTodos();
                return Ok(todasTimes);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpGet]
        [Route("time/obterPorId/{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var time = Repositorio.ObterPorId(id);

                if (time == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(time);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPost]
        [Route("time/adicionar")]
        public IActionResult Adicionar([FromBody] Time time)
        {
            try
            {
                if (time == null)
                {
                    return BadRequest("Não foi possível obter a time");
                }

                Repositorio.Adicionar(time);

                return Created($"", time);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpPut]
        [Route("time/atualizar")]
        public IActionResult Atualizar([FromBody] Time time)
        {
            try
            {
                Time timeAtualizar = Repositorio.ObterPorId(time.Id);

                if (timeAtualizar == null)
                {
                    return NotFound("Não foi possível encontrar a time");
                }
                else
                {
                    //timeAtualizar.Id = 1;
                    timeAtualizar.Nome = time.Nome;
                    timeAtualizar.Divisao = time.Divisao;
                    timeAtualizar.NomeTecnico = time.NomeTecnico;
                    timeAtualizar.Cidade = time.Cidade;

                    Repositorio.Atualizar(timeAtualizar);
                    return Ok(timeAtualizar);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }

        [HttpDelete]
        [Route("time/excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                var time = Repositorio.ObterPorId(id);

                if (time == null)
                {
                    return NotFound("Time não encontrada");
                }

                Repositorio.Excluir(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro na API: {ex.Message} - {ex.StackTrace}");
            }
        }
    }
}
