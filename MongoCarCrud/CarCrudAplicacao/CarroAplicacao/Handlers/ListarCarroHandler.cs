using CarCrudAplicacao.CarroAplicacao.Comandos;
using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;

namespace CarCrudAplicacao.CarroAplicacao.Handlers
{
    public class ListarCarroHandler
    {
        private readonly ICarroRepositorio CarroRepositorio;
        public ListarCarroHandler(IConfiguration configuration)
        {
            CarroRepositorio = new CarroRepositorio(configuration);
        }
        public List<Carro> Handle(ListarCarroComando request)
        {
            return CarroRepositorio.Listar();
        }
    }
}
