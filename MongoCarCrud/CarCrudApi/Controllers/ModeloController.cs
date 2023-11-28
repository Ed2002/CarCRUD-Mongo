using CarCrudAplicacao.ModeloAplicacao.Comandos;
using CarCrudAplicacao.ModeloAplicacao.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CarCrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        private readonly ListarModeloHandler ListarModeloHandler;
        private readonly InserirModeloHandler InserirModeloHandler;
        private readonly AlterarModeloHandler AlterarModeloHandler;
        private readonly BuscarIdModeloHandler BuscarIdModeloHandler;


        public ModeloController(IConfiguration configuration)
        {
            ListarModeloHandler = new ListarModeloHandler(configuration);
            InserirModeloHandler = new InserirModeloHandler(configuration);
            BuscarIdModeloHandler = new BuscarIdModeloHandler(configuration);
            AlterarModeloHandler = new AlterarModeloHandler(configuration);
        }

        [HttpPost]
        public IActionResult Inserir(InserirModeloComandos dados)
        {
            InserirModeloHandler.Handle(dados);
            return Ok();
        }

        [HttpPatch]
        public IActionResult Alterar(AlterarModeloComando dados)
        {
            AlterarModeloHandler.Handle(dados);
            return Ok();
        }

        [HttpGet("BuscarId")]
        public IActionResult BuscarPorId([FromQuery] BuscarIdModeloComando dados)
        {
            return Ok(BuscarIdModeloHandler.Handle(dados));
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(ListarModeloHandler.Handle(new ListarModeloComando()));
        }
    }
}
