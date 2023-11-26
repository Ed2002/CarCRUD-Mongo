using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.MarcaAplicacao.Handlers
{
    public class BuscarIdMarcaHandler
    {
        private readonly IMarcaRepositorio MarcaRepositorio;
        public BuscarIdMarcaHandler(IConfiguration configuration)
        {
            MarcaRepositorio = new MarcaRepositorio(configuration);
        }
        public Marca Handle(BuscarIdMarcaComando request)
        {
            return MarcaRepositorio.BuscarId(request.Id);
        }
    }
}
