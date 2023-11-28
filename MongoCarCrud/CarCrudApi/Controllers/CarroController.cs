using CarCrudAplicacao.CarroAplicacao.Comandos;
using CarCrudAplicacao.CarroAplicacao.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CarCrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly ListarCarroHandler ListarCarroHandler;
        private readonly InserirCarroHandler InserirCarroHandler;
        private readonly AlterarCarroHandler AlterarCarroHandler;
        private readonly BuscarIdCarroHandler BuscarIdCarroHandler;


        public CarroController(IConfiguration configuration)
        {
            ListarCarroHandler = new ListarCarroHandler(configuration);
            InserirMCarroHandler = new InserirCarroHandler(configuration);
            BuscarIdMCarroHandler = new BuscarIdCarroHandler(configuration);
            AlterarCarroHandler = new AlterarCarroHandler(configuration);
        }

        [HttpPost]
        public IActionResult Inserir(InserirCarroComandos dados)
        {
            InserirCarroHandler.Handle(dados);
            return Ok();
        }

        [HttpPatch]
        public IActionResult Alterar(AlterarCarroComando dados)
        {
            AlterarCarroHandler.Handle(dados);
            return Ok();
        }

        [HttpGet("BuscarId")]
        public IActionResult BuscarPorId([FromQuery] BuscarIdCarroComando dados)
        {
            return Ok(BuscarIdCarroHandler.Handle(dados));
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(ListarCarroHandler.Handle(new ListarCarroComando()));
        }
    }
}
