using CarCrudAplicacao.CarroAplicacao.Comandos;
using CarCrudDominio.Repositorios;
using CarCrudInfra.Repositorios;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;

namespace CarCrudAplicacao.CarroAplicacao.Handlers
{
    public class InserirCarroHandler
    {
        private readonly ICarroRepositorio CarroRepositorio;
        public InserirCarroHandler(IConfiguration configuration)
        {
            CarroRepositorio = new CarroRepositorio(configuration);
        }
        public async Task Handle(InserirCarroComandos request)
        {
            await CarroRepositorio.Inserir(new()
            {
                Nome = request.Nome,
                Renavam = request.Renavam,
                Placa = request.Placa,
                Valor = request.Valor,
                Ano = request.Ano,
            });
        }
    }
}
