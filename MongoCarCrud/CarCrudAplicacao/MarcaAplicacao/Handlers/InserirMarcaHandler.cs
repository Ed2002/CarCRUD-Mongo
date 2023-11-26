using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;

namespace CarCrudAplicacao.MarcaAplicacao.Handlers
{
    public class InserirMarcaHandler
    {
        private readonly IMarcaRepositorio MarcaRepositorio;
        public InserirMarcaHandler(IConfiguration configuration)
        {
            MarcaRepositorio = new MarcaRepositorio(configuration);
        }
        public async Task Handle(InserirMarcaComandos request)
        {
            await MarcaRepositorio.Inserir(new()
            {
                Nome = request.Nome,
            });
        }
    }
}
