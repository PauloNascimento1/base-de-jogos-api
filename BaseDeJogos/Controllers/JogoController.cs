using BaseDeJogos.Data;
using BaseDeJogos.Model;
using BaseDeJogos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaseDeJogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly JogoService _jogoService;
        

        public JogoController(JogoService jogoService)
        {
            _jogoService = jogoService;
            
        }

        [HttpGet("{id}")]

        public IActionResult ProcurarPorId(int id) 
        {
            var procurarJogo = _jogoService.ProcurarPorId(id);
            return Ok(procurarJogo);
        }


        [HttpGet]

        public IActionResult ExibirJogos()
        {

            var listarJogos = _jogoService.ExibirJogos();

            return Ok(listarJogos);
        }

        [HttpPost]

        public IActionResult AdicionarJogo(JogoModel jogo)
        {
            var adicionarJogo = _jogoService.AdicionarJogo(jogo);

            return Ok(adicionarJogo);
        }

        [HttpDelete]

        public IActionResult DeletarJogo(int id)
        {
            var deletarJogo = _jogoService.DeletarJogo(id);
           
            return Ok(deletarJogo);
        }

        [HttpPut]

        public IActionResult AtualizarJogo(JogoModel jogo)
        {
            var atualizaJogo = _jogoService.AtualizarJogo;
            return Ok(atualizaJogo);
        }
        

    }
}
