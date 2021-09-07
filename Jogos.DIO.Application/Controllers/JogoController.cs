using Microsoft.AspNetCore.Mvc;
using Jogos.DIO.Domain.Interfaces.Services;
using Jogos.DIO.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jogos.DIO.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : Controller
    {
        private readonly IJogoService _jogoService;

        public JogoController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }


        [HttpPost]
        public async Task<IActionResult> Salvar([FromBody] JogoModel jogo)
        {
            await _jogoService.Inserir(jogo);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] JogoModel jogo)
        {
            await _jogoService.Atualizar(jogo);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir([FromRoute] int id)
        {
            await _jogoService.Excluir(id);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JogoModel>>> Listar()
        {
            var users = await _jogoService.Listar();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JogoModel>> ConsultarPorId([FromRoute] int id)
        {
            var jogo = await _jogoService.ConsultarPorId(id);
            return Ok(jogo);
        }
    }
}
