using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CarCrudInfra.Repositorios
{
    public class ModeloRepositorio : IModeloRepositorio
    {
        private readonly IMongoCollection<Modelo> Connection;

        public ModeloRepositorio(IConfiguration configuration)
        {
            Connection = new MongoFactory<Modelo>(configuration).Connect("modelo");
        }

        public async Task Inserir(Modelo modelo)
        {
            try
            {
                var maxDoc = Connection.AsQueryable()
                                    .OrderByDescending(x => x.Id)
                                    .FirstOrDefault();

                await Connection.InsertOneAsync(new()
                {
                    Id = (maxDoc?.Id ?? 0) + 1,
                    Nome = modelo.Nome,
                    IdMarca = modelo.IdMarca
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir um Modelo {ex.Message}");
            }
        }

        public async Task Alterar(Modelo modelo)
        {
            try
            {
                var filtro = Builders<Modelo>.Filter.Eq(x => x.Id, modelo.Id);

                var atualizacao = Builders<Modelo>.Update
                    .Set(x => x.Nome, modelo.Nome)
                    .Set(x => x.IdMarca, modelo.IdMarca);

                await Connection.UpdateOneAsync(filtro, atualizacao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Alterar um Modelo {ex.Message}");
            }
        }

        public List<Modelo> Listar()
        {
            try
            {
                return Connection.AsQueryable().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Listar Modelos {ex.Message}");
            }
        }

        public Modelo BuscarId(long Id)
        {
            try
            {
                return Connection.AsQueryable().Where(x => x.Id.Equals(Id)).First();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar um Modelo {ex.Message}");
            }
        }

        public async Task Deletar(long Id)
        {
            try
            {
                var filtro = Builders<Modelo>.Filter.Eq(x => x.Id, Id);

                await Connection.DeleteOneAsync(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar um Modelo {ex.Message}");
            }
        }
    }
}
