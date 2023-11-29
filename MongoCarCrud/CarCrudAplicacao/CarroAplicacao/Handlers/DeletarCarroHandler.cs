using CarCrudAplicacao.CarroAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCrudAplicacao.CarroAplicacao.Handlers
{
    public class DeletarCarroHandler
    {
        private readonly ICarroRepositorio CarroRepositorio;
        public DeletarCarroHandler(IConfiguration configuration)
        {
            CarroRepositorio = new CarroRepositorio(configuration);
        }
        public async Task Handle(DeletarCarroComando request)
        {
            await CarroRepositorio.Deletar(request.Id);
        }
    }
}
