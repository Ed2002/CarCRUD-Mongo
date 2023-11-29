using MongoDB.Bson;

namespace CarCrudDominio.Entidades
{
    public class Carro
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public int Renavam { get; set; }
        public string Placa { get; set; }
        public float Valor { get; set; }
        public string Ano { get; set; }
        public long? IdModelo { get; set; }
    }
}
