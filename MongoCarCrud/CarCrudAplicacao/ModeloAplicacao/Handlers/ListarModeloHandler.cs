using CarCrudAplicacao.ModeloAplicacao.Comandos;
using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.ModeloAplicacao.Handlers
{
    public class ListarModeloHandler
    {
        private readonly IModeloRepositorio ModeloRepositorio;
        public ListarModeloHandler(IConfiguration configuration)
        {
            ModeloRepositorio = new ModeloRepositorio(configuration);
        }
        public List<Modelo> Handle(ListarModeloComando request)
        {
            return ModeloRepositorio.Listar();
        }
    }
}
