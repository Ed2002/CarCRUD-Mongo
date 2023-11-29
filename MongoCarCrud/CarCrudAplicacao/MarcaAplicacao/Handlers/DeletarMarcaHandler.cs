using CarCrudAplicacao.MarcaAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCrudAplicacao.MarcaAplicacao.Handlers
{
    public class DeletarMarcaHandler
    {
        private readonly IMarcaRepositorio MarcaRepositorio;
        public DeletarMarcaHandler(IConfiguration configuration)
        {
            MarcaRepositorio = new MarcaRepositorio(configuration);
        }
        public async Task Handle(DeletarMarcaComando request)
        {
            await MarcaRepositorio.Deletar(request.Id);
        }
    }
}
