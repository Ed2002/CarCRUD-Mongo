using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.MarcaAplicacao.Handlers
{
    public class ListarMarcaHandler
    {
        private readonly IMarcaRepositorio MarcaRepositorio;
        public ListarMarcaHandler(IConfiguration configuration)
        {
            MarcaRepositorio = new MarcaRepositorio(configuration);
        }
        public List<Marca> Handle(ListarMarcaComando request)
        {
            return MarcaRepositorio.Listar();
        }
    }
}
