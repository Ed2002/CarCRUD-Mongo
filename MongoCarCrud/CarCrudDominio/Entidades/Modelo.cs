using MongoDB.Bson;

namespace CarCrudDominio.Entidades
{
    public class Modelo
    {
        public long? Id { get; set; }

        public string Nome { get; set; }

        public long? IdMarca { get; set; }
    }
}
