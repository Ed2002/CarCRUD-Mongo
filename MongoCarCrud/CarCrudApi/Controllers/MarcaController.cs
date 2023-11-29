using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudAplicacao.MarcaAplicacao.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CarCrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly ListarMarcaHandler ListarMarcaHandler;
        private readonly InserirMarcaHandler InserirMarcaHandler;
        private readonly AlterarMarcaHandler AlterarMarcaHandler;
        private readonly BuscarIdMarcaHandler BuscarIdMarcaHandler;
        private readonly DeletarMarcaHandler DeletarMarcaHandler;

        public MarcaController(IConfiguration configuration)
        {
            ListarMarcaHandler = new ListarMarcaHandler(configuration);
            InserirMarcaHandler = new InserirMarcaHandler(configuration);
            BuscarIdMarcaHandler = new BuscarIdMarcaHandler(configuration);
            AlterarMarcaHandler = new AlterarMarcaHandler(configuration);
            DeletarMarcaHandler = new DeletarMarcaHandler(configuration);
        }

        [HttpPost]
        public IActionResult Inserir(InserirMarcaComandos dados)
        {
            InserirMarcaHandler.Handle(dados);
            return Ok();
        }

        [HttpPatch]
        public IActionResult Alterar(AlterarMarcaComando dados)
        {
            AlterarMarcaHandler.Handle(dados);
            return Ok();
        }

        [HttpGet("BuscarId")]
        public IActionResult BuscarPorId([FromQuery]BuscarIdMarcaComando dados) 
        {
            return Ok(BuscarIdMarcaHandler.Handle(dados));
        }

        [HttpGet]
        public IActionResult Listar() 
        {
            return Ok(ListarMarcaHandler.Handle(new ListarMarcaComando()));
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] DeletarMarcaComando dados)
        {
            DeletarMarcaHandler.Handle(dados);
            return Ok();
        }
    }
}
