using CarCrudDominio.Entidades;
using CarCrudDominio.Repositorios;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CarCrudInfra.Repositorios
{
    public class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly IMongoCollection<Marca> Connection;

        public MarcaRepositorio(IConfiguration configuration)
        {
            Connection = new MongoFactory<Marca>(configuration).Connect("marca");
        }

        public async Task Inserir(Marca marca)
        {
            try
            {
                var maxDoc = Connection.AsQueryable()
                                    .OrderByDescending(x => x.Id)
                                    .FirstOrDefault();

                await Connection.InsertOneAsync(new()
                {
                    Id = (maxDoc?.Id ?? 0) + 1,
                    Nome = marca.Nome
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir uma Marca {ex.Message}");
            }
        }

        public async Task Alterar(Marca marca)
        {
            try
            {
                var filtro = Builders<Marca>.Filter.Eq(x=>x.Id,marca.Id);

                var atualizacao = Builders<Marca>.Update.Set(x=>x.Nome,marca.Nome);

                await Connection.UpdateOneAsync(filtro, atualizacao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Alterar uma Marca {ex.Message}");
            }
        }

        public List<Marca> Listar()
        {
            try
            {
                return Connection.AsQueryable().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Listar Marcas {ex.Message}");
            }
        }

        public Marca BuscarId(long Id)
        {
            try
            {
                return Connection.AsQueryable().Where(x => x.Id.Equals(Id)).First();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar uma Marca {ex.Message}");
            }
        }
    }
}
