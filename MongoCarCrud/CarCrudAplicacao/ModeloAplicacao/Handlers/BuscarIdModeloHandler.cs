using CarCrudAplicacao.ModeloAplicacao.Comandos;
using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.ModeloAplicacao.Handlers
{
    public class BuscarIdModeloHandler
    {
        private readonly IModeloRepositorio ModeloRepositorio;
        public BuscarIdModeloHandler(IConfiguration configuration)
        {
            ModeloRepositorio = new ModeloRepositorio(configuration);
        }
        public Modelo Handle(BuscarIdModeloComando request)
        {
            return ModeloRepositorio.BuscarId(request.Id);
        }
    }
}
