using CarCrudAplicacao.ModeloAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;

namespace CarCrudAplicacao.ModeloAplicacao.Handlers
{
    public class InserirModeloHandler
    {
        private readonly IModeloRepositorio ModeloRepositorio;
        public InserirModeloHandler(IConfiguration configuration)
        {
            ModeloRepositorio = new ModeloRepositorio(configuration);
        }
        public async Task Handle(InserirModeloComandos request)
        {
            await ModeloRepositorio.Inserir(new()
            {
                Nome = request.Nome,
            });
        }
    }
}
