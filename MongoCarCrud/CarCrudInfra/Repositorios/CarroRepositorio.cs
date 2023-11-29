using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CarCrudInfra.Repositorios
{
    public class CarroRepositorio : ICarroRepositorio
    {
        private readonly IMongoCollection<Carro> Connection;

        public CarroRepositorio(IConfiguration configuration)
        {
            Connection = new MongoFactory<Carro>(configuration).Connect("carro");
        }

        public async Task Inserir(Carro carro)
        {
            try
            {
                var maxDoc = Connection.AsQueryable()
                                    .OrderByDescending(x => x.Id)
                                    .FirstOrDefault();

                await Connection.InsertOneAsync(new()
                {
                    Id = (maxDoc?.Id ?? 0) + 1,
                    Nome = carro.Nome,
                    Placa = carro.Placa,
                    Renavam = carro.Renavam,
                    Valor = carro.Valor,
                    IdModelo = carro.IdModelo,
                    Ano = carro.Ano
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir um Carro {ex.Message}");
            }
        }

        public async Task Alterar(Carro carro)
        {
            try
            {
                var filtro = Builders<Carro>.Filter.Eq(x => x.Id, carro.Id);

                var atualizacao = Builders<Carro>.Update
                    .Set(x => x.Nome, carro.Nome)
                    .Set(x => x.Placa, carro.Placa)
                    .Set(x => x.Renavam, carro.Renavam)
                    .Set(x => x.Valor, carro.Valor)
                    .Set(x => x.Ano, carro.Ano)
                    .Set(x => x.IdModelo, carro.IdModelo);

                await Connection.UpdateOneAsync(filtro, atualizacao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Alterar um Carro {ex.Message}");
            }
        }

        public List<Carro> Listar()
        {
            try
            {
                return Connection.AsQueryable().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Listar Carros {ex.Message}");
            }
        }

        public Carro BuscarId(long Id)
        {
            try
            {
                return Connection.AsQueryable().Where(x => x.Id.Equals(Id)).First();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar um Carro {ex.Message}");
            }
        }

        public async Task Deletar(long Id)
        {
            try
            {
                var filtro = Builders<Carro>.Filter.Eq(x => x.Id, Id);

                await Connection.DeleteOneAsync(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar um Modelo {ex.Message}");
            }
        }
    }
}
