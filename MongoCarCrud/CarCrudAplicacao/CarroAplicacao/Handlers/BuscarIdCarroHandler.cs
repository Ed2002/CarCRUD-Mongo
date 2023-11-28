using CarCrudAplicacao.CarroAplicacao.Comandos;
using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.MarcaAplicacao.Handlers
{
    public class BuscarIdCarroHandler
    {
        private readonly ICarroRepositorio CarroRepositorio;
        public BuscarIdCarroHandler(IConfiguration configuration)
        {
            CarroRepositorio = new CarroRepositorio(configuration);
        }
        public Carro Handle(BuscarIdCarroComando request)
        {
            return CarroRepositorio.BuscarId(request.Id);
        }
    }
}
