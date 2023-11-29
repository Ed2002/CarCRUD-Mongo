using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudAplicacao.ModeloAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.ModeloAplicacao.Handlers
{
    public class DeletarModeloHandler
    {
        private readonly IModeloRepositorio ModeloRepositorio;
        public DeletarModeloHandler(IConfiguration configuration)
        {
            ModeloRepositorio = new ModeloRepositorio(configuration);
        }
        public async Task Handle(DeletarModeloComando request)
        {
            await ModeloRepositorio.Deletar(request.Id);
        }
    }
}
