using CarCrudAplicacao.ModeloAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.ModeloAplicacao.Handlers
{
    public class AlterarModeloHandler
    {
        private readonly IModeloRepositorio ModeloRepositorio;
        public AlterarModeloHandler(IConfiguration configuration)
        {
            ModeloRepositorio = new ModeloRepositorio(configuration);
        }
        public async Task Handle(AlterarModeloComando request)
        {
            await ModeloRepositorio.Alterar(request);
        }
    }
}
