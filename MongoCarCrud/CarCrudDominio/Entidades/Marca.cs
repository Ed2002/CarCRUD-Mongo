using MongoDB.Bson;

namespace CarCrudDominio.Entidades
{
    public class Marca
    {
        public long? Id { get; set; }
        public string Nome { get; set; } = string.Empty;
    }
}
