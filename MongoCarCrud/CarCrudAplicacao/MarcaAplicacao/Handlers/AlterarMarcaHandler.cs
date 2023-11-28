using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.MarcaAplicacao.Handlers
{
    public class AlterarMarcaHandler
    {
        private readonly IMarcaRepositorio MarcaRepositorio;
        public AlterarMarcaHandler(IConfiguration configuration)
        {
            MarcaRepositorio = new MarcaRepositorio(configuration);
        }
        public async Task Handle(AlterarMarcaComando request)
        {
            await MarcaRepositorio.Alterar(request);
        }
    }
}
