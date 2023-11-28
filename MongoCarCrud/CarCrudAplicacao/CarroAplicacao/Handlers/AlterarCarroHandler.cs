using CarCrudAplicacao.CarroAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.CarroAplicacao.Handlers
{
    public class AlterarCarroHandler
    {
        private readonly ICarroRepositorio CarroRepositorio;
        public AlterarCarroHandler(IConfiguration configuration)
        {
            CarroRepositorio = new CarroRepositorio(configuration);
        }
        public async Task Handle(AlterarCarroComando request)
        {
            await CarroRepositorio.Alterar(request);
        }
    }
}
